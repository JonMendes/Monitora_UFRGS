const aulasModel = require('../models/aulasModel');

async function solicitarAula(request, response){
  const createdAula = await aulasModel.solicitarAula(request.body);
  return response.status(201).json(createdAula);
}

async function getAulas(request, response){
  const {cartao} = request.params;
  const aulas = await aulasModel.getAulas(cartao);
  return response.status(200).json(aulas);
}

module.exports = {
  solicitarAula,
  getAulas
};