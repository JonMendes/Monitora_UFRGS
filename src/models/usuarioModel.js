const { client } = require('./connection');

const getUsuario = async (cartao) => {
  const query = await client.query('SELECT * FROM usuarios WHERE idUsuario = $1', [cartao]);
  return query;
};

module.exports = {
  getUsuario
};
