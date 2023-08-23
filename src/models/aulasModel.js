const { client } = require('./connection');

async function solicitarAula(aula) {
  const {idAluno, idMonitor, disciplina, status, inicio, fim, modalidade} = aula;

  const query = `INSERT INTO aulas(idAluno, idMonitor, disciplina, status, inicio, fim, modalidade)
                VALUES ($1, $2, $3, $4, $5, $6, $7)`;

  const createdAula = await client.query(query, [idAluno, idMonitor, disciplina, status, inicio, fim, modalidade]);

  return {idAula: createdAula.idAula};
}

module.exports = {
  solicitarAula
};