const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");

const fetchUsuario = async () => {
  const cartao = loginForm.dado_cartao.value;
  const response = await fetch(`http://localhost:3333/login/${cartao}`);
  const respJSON = await response.json();
  return respJSON.rows[0];
}

loginButton.addEventListener("click", (e) => {
  e.preventDefault();
  const password = loginForm.dado_senha.value;
  fetchUsuario().then((usuario) => {
    if (usuario.senha === password) {
      if(usuario.cargo === 'professor'){    // ADICIONAR CASO não for aluno nem professor nem monitor
        window.location.replace("..\\html\\professor.html");
      }
      else{
        window.location.replace("..\\html\\aluno.html");
      }
    }
  });
})
