const { client } = require('./connection');

const createUsuario = async (user) => {
  const { idusuario, nome, senha, curso } = user;

  const query = 'INSERT INTO usuarios(idusuario, nome, senha, curso, cargo) VALUES ($1, $2, $3, $4, $5)';

  const createdUser = await client.query(query, [idusuario, nome, senha, curso, 'aluno']);

  return {insertId: createdUser.insertId};
};

module.exports = {
  createUsuario
};
