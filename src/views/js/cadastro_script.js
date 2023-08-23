const cadastroForm = document.getElementById("cadastro-form");
const cadastroButton = document.getElementById("cadastro-form-submit");

const verificaCadastro = async () => {
  const cartao = cadastroForm.dado_cartao.value;
  const response = await fetch(`http://localhost:3333/exists/${cartao}`);
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

  // TO DO: verificar se o cadastro já existe
  await verificaCadastro().then((existe) => {
    if(existe.exists){
      alert("Este cartão já está cadastrado!");
      location.reload();
    }
  });

  if(senha === conf_senha){
    await fetch('http://localhost:3333/cadastro', {
      method: 'post',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(usuario),
    });
  }
  else{
    alert("Senhas não são iguais!");
  }

  // TO DO: confirmação de cadastro realizado
  await verificaCadastro().then((existe) => {
    if(existe.exists){
      alert("Cadastro realizado com sucesso!");
      window.location.replace("..\\html\\index.html");
    }
  });
}

cadastroButton.addEventListener("click", criarUsuario);
