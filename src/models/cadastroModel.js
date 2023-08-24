const { client } = require('./connection');

const createUsuario = async (user) => {
  const { idusuario, nome, senha, curso } = user;

  const query = 'INSERT INTO usuarios(idusuario, nome, senha, curso, cargo) VALUES ($1, $2, $3, $4, $5)';

  const createdUser = await client.query(query, [idusuario, nome, senha, curso, 'aluno']);

  return {insertId: createdUser.insertId};
};

const existeUsuario = async (idUsuario) => {
  const query = 'SELECT EXISTS(SELECT * FROM usuarios WHERE idUsuario = $1)';

  const exists = await client.query(query, [idUsuario]);

  return exists;
};

const listaUsuarios = async (disciplina) => {
  
  const query = 'SELECT * FROM usuarios WHERE disciplina = $1 AND cargo = Monitor';

  const exists = await client.query(query, [disciplina]);
  //const exists = query.rows;

  return exists;
};

module.exports = {
  createUsuario,
  existeUsuario,
  listaUsuarios
};
