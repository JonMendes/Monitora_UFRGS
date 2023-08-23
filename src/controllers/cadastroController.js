const cadastroModel = require('../models/cadastroModel');

const createUsuario = async (request, response) => {
  const createdUser = await cadastroModel.createUsuario(request.body);
  return response.status(201).json(createdUser);
};

const existeUsuario = async (request, response) => {
  const {cartao} = request.params;
  const exists = await cadastroModel.existeUsuario(cartao);
  return response.status(200).json(exists);
};

module.exports = {
  createUsuario,
  existeUsuario
};
