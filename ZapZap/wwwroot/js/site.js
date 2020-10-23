/* Conexão e reconexão com o SiganlR - Hub */
const connection = new signalR.HubConnectionBuilder().withUrl("/ZapZapHub").build();

function ConnectionStart() {
    connection.start().then(function () {
        Logar();
        HabilitarCadastro();
        HabilitarConversacao();
        console.info("This connected");
    }).catch(error => {
        console.error(error.toString());
        setTimeout(ConnectionStart(), 5000);
    });
}

// Todo vez que a conexão cair vai tenta revezer ela
connection.onclose(async () => { await ConnectionStart() });

function HabilitarCadastro() {

    const cadastrar = document.getElementById("cadastrar");

    if (cadastrar != null) {
        const btnCadastrar = document.getElementById("btnCadastrar");

        btnCadastrar.addEventListener("click", function () {
            let name = document.getElementById("name").value;
            let email = document.getElementById("email").value;
            let password = document.getElementById("password").value;

            let user = { Name: name, Email: email, Password: password }

            connection.invoke("Cadastrar", user);
        });

    }

    connection.on("ReceberCadastro", function (sucesso, usuario, msg) {
        let mensagem = document.getElementById("mensagem");

        if (sucesso) {
            console.info(usuario);

            document.getElementById("name").value = '';
            document.getElementById("email").value = '';
            document.getElementById("password").value = '';
        }

        mensagem.innerHTML = msg;
    });
}

function Logar() {
    const logar = document.getElementById("form-login");

    if (logar != null) {
        let btnAcessar = document.getElementById("btnAcessar")

        btnAcessar.addEventListener("click", function () {
            let email = document.getElementById("email").value;
            let senha = document.getElementById("senha").value;

            let user = { Email: email, Password: senha }

            connection.invoke("Login", user);
        });
    }

    connection.on("ReceberLogin", function (sucesso, usuario, msg) {
        let mensagem = document.getElementById("msg");

        if (sucesso) {

            SetUserLogado(usuario);
            window.location.href = "/Home/Conversacao";
        } 

        return mensagem.innerText = msg;
        
    });
}

function HabilitarConversacao() {
    connection.invoke("AddConnectionIdUser", GetUserLogado());

    DelSessionUser();
}

const telaConversacao = document.getElementById("tela-conversacao");
if (telaConversacao != null) {
    if (GetUserLogado() == null) {
        window.location.href = "/Home/Login";
    }  
}



function GetUserLogado() {
    return JSON.parse(sessionStorage.getItem("Logado"));
}

function SetUserLogado(usuario) {
    sessionStorage.setItem("Logado", JSON.stringify(usuario));
}

function DelSessionUser() {
    let sair = document.getElementById("logaut");
    sair.addEventListener("click", function () {
        connection.invoke("DelConnectionIdUser", GetUserLogado()).then(function () {
            sessionStorage.removeItem("Logado");
            return window.location.href = "/Home/Login"
        });
    }); 
}


ConnectionStart();