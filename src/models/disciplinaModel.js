const { client } = require('./connection');

async function getDisciplina(nome){
  const query = await client.query('SELECT * FROM disciplinas WHERE nome = $1', [nome.nome]);
  return query;
}

module.exports = {
  getDisciplina
};
