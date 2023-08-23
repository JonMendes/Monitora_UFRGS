const cadastroForm = document.getElementById("cadastro-form");
const cadastroButton = document.getElementById("cadastro-form-submit");

const fetchUsuario = async () => {
  const cartao = loginForm.dado_cartao.value;
  const response = await fetch(`http://localhost:3333/login/${cartao}`);
  const respJSON = await response.json();
  return respJSON.rows[0];
}

const criarUsuario = async (event) => {
  event.preventDefault();

  const usuario = {
    nome: cadastroForm.dado_nome.value,
    idusuario: cadastroForm.dado_cartao.value,
    curso: cadastroForm.dado_curso.value,
    senha: cadastroForm.dado_senha.value,
  }
  
  const senha = cadastroForm.dado_senha.value;
  const conf_senha = cadastroForm.dado_confsenha.value;

  // TO DO: erificar se o cadastro já existe

  if(senha === conf_senha){
    await fetch('http://localhost:3333/cadastro', {
      method: 'post',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(usuario),
    });

    // TO DO: enviar alerta de confirmação de cadastro realizado

    window.location.replace("..\\html\\index.html");
  }
  else{
    alert("Senhas não são iguais!");
  }

}

cadastroButton.addEventListener("click", criarUsuario);
