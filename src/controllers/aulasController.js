const aulasModel = require('../models/aulasModel');

async function solicitarAula(request, response){
  const createdAula = await aulasModel.solicitarAula(request.body);
  return response.status(201).json(createdAula);
}

module.exports = {
  solicitarAula
};