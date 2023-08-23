const { client } = require('./connection');

async function solicitarAula(aula) {
  const {idAluno, idMonitor, disciplina, status, inicio, fim, modalidade} = aula;

  const query = `INSERT INTO aulas(idAluno, idMonitor, disciplina, status, inicio, fim, modalidade)
                VALUES ($1, $2, $3, $4, $5, $6, $7)`;

  const createdAula = await client.query(query, [idAluno, idMonitor, disciplina, status, inicio, fim, modalidade]);

  return {idAula: createdAula.idAula};
}

async function getAulas(idAluno) {
  const query = await client.query('SELECT * FROM aulas WHERE idAluno = $1', [idAluno]);
  const aulas = query.rows;
  return aulas;
};

module.exports = {
  solicitarAula,
  getAulas
};