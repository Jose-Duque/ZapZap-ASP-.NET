using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace ZapZap.Models
{
    public class User // - Cadastro de Usuario
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsOnline { get; set; }

        public string ConnectionId { get; set; }
    }
}