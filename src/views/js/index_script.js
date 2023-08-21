const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

// fetchSenha chamado pelo evento "click" da linha 37
// Se a página recarregar, reescrever como 'async (event)' e descomentar o event.prevent.Default()
// const username é um objeto com um único campo (cartao) que é enviado como string pelo fetch
const fetchSenha = async () => {
  //event.preventDefault();

  const username = { cartao: loginForm.dado_cartao.value };

  const response = await fetch('http://localhost:3333/login', {
    method: 'post',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(username),
  })
  const senha = await response.json();
  return senha;
}

// fetchSenha sem argumento, ou seja, inútil, só para comparação caso tenha algum problema no código acima
const fetchSenha0 = async () => {
  const response = await fetch('http://localhost:3333/login')
  const senha = await response.json()
  return senha;
}

loginButton.addEventListener("click", (e) => 
{
    e.preventDefault();
    //const username = loginForm.dado_cartao.value;
    const password = loginForm.dado_senha.value;
    const db_password = fetchSenha();

    if (db_password === password) {
        //alert("You have successfully logged in.");
        //location.reload();
        window.location.replace("..\\html\\home.html")
    } 
    
    else
    {
      alert("Errou, burrão. admin/admin.");
      location.reload();
    }
})


