const disciplinaModel = require('../models/disciplinaModel');

async function getDisciplina(request, response){
  const disciplina = await disciplinaModel.getDisciplina(request.body);
  return response.status(200).json(disciplina);
}

module.exports = {
  getDisciplina
};
