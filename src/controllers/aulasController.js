const aulasModel = require('../models/aulasModel');

async function solicitarAula(request, response){
  const createdAula = await aulasModel.solicitarAula(request.body);
  return response.status(201).json(createdAula);
}

async function getAulasAluno(request, response){
  const {cartao} = request.params;
  const aulas = await aulasModel.getAulasAluno(cartao);
  return response.status(200).json(aulas);
}

async function getAulasMonitor(request, response){
  const {cartao} = request.params;
  const aulas = await aulasModel.getAulasMonitor(cartao);
  return response.status(200).json(aulas);
}

module.exports = {
  solicitarAula,
  getAulasAluno,
  getAulasMonitor
};