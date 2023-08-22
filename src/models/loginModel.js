const { client } = require('./connection');

const getSenha = async (cartao) => {
  const query = await client.query('SELECT senha FROM usuarios WHERE idUsuario = $1', [cartao]);
  const senha = query;
  return senha;
};

module.exports = {
  getSenha
};
