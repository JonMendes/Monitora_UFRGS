const usuario = JSON.parse(window.localStorage.getItem('dadosUsuario'));

console.log(usuario);

document.getElementById("dados_cartao").innerHTML = 'Cartão: '+usuario.idusuario
document.getElementById("dados_nome").innerHTML = 'Nome: '+usuario.nome
document.getElementById("dados_curso").innerHTML = 'Curso: '+usuario.curso
