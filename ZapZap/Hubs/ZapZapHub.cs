using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZapZap.Database;
using ZapZap.Models;

// Lado do Servidor

namespace ZapZap.Hubs
{
    public class ZapZapHub : Hub
    {
        private BancoContext _banco;

        public ZapZapHub(BancoContext banco)
        {
            _banco = banco;

        }

        public async Task Cadastrar(User user)
        {
            bool ExistUser = _banco.Users.Where(a => a.Email == user.Email).Count() > 0;

            if (ExistUser)
            {
                await Clients.Caller.SendAsync("ReceberCadastro", false, null, "E-mail já cadastrado");
            } 
            else
            {
                _banco.Users.Add(user);
                _banco.SaveChanges();

                await Clients.Caller.SendAsync("ReceberCadastro", true, user, "Usuário cadastrado com sucesso!");
            }
        }

        public async Task Login(User user)
        {
            var LoginUser = _banco.Users.FirstOrDefault(a => a.Email == user.Email && a.Password == user.Password);

           if (LoginUser == null)
            {
                await Clients.Caller.SendAsync("ReceberLogin", false, null, "E-mail e ou senha não confere");
            } 
            else
            {
                await Clients.Caller.SendAsync("ReceberLogin", true, LoginUser, null);
                
            }
        }

        public void AddConnectionIdUser(User user)
        {
            var ConnectionIdCurrent = Context.ConnectionId;
            List<string> connectionsId = null;

            User userDb = _banco.Users.Find(user.Id);
            if (userDb.ConnectionId == null)
            {
                connectionsId = new List<string>();
                connectionsId.Add(ConnectionIdCurrent);

            }
             else {

                connectionsId = JsonConvert.DeserializeObject<List<string>>(userDb.ConnectionId);
                if (!connectionsId.Contains(ConnectionIdCurrent))
                {
                    connectionsId.Add(ConnectionIdCurrent);
                }

             }
                userDb.ConnectionId = JsonConvert.SerializeObject(connectionsId);
                _banco.Users.Update(userDb);
                _banco.SaveChanges();
            
            // Todo - Adicionar aos grupos de conversa desses usúarios
        }

        public void DelConnectionIdUser(User user)
        {
            User userDb = _banco.Users.Find(user.Id);
            if (userDb.ConnectionId.Length > 0)
            {
                var ConnectionIdCurrent =  Context.ConnectionId;

                List<string> connectionsId = JsonConvert.DeserializeObject<List<string>>(userDb.ConnectionId);

                if (connectionsId.Contains(ConnectionIdCurrent))
                {
                     connectionsId.Remove(ConnectionIdCurrent);
                }

                userDb.ConnectionId = JsonConvert.SerializeObject(connectionsId);
                _banco.Users.Update(userDb);
                _banco.SaveChanges();
            }

            // Todo - Remover connectionId dos grupos de conversa desses usúarios
        }
    }
}
