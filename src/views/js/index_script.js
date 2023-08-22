const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

// fetchSenha chamado pelo evento "click" da linha 37
// Se a página recarregar, reescrever como 'async (event)' e descomentar o event.prevent.Default()
// const username é um objeto com um único campo (cartao) que é enviado como string pelo fetch
const fetchSenha = async () => {
  //event.preventDefault();

  const cartao = loginForm.dado_cartao.value;
  const response = await fetch(`http://localhost:3333/login/${cartao}`)
  const respJSON = await response.json();
  const parsedData = respJSON.rows;
  const senha = parsedData[0].senha;
  console.log(senha);
  return senha;
}

loginButton.addEventListener("click", (e) => 
{
    e.preventDefault();
    //const username = loginForm.dado_cartao.value;
    const password = loginForm.dado_senha.value;
    // let db_password;
    fetchSenha().then((result) => {
      if (result === password) {
        //alert("You have successfully logged in.");
        //location.reload();
        window.location.replace("..\\html\\home.html")
      }
    });
    // console.log(password);
    // console.log(db_password);

    // if (db_password === password) {
    //     //alert("You have successfully logged in.");
    //     //location.reload();
    //     window.location.replace("..\\html\\home.html")
    // }
    
    // else
    // {
    //   alert("Errou, burrão. admin/admin.");
    //   location.reload();
    // }
})


