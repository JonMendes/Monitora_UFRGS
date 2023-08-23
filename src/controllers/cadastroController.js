const cadastroModel = require('../models/cadastroModel');

const createUsuario = async (request, response) => {
  const createdUser = await cadastroModel.createUsuario(request.body);
  return response.status(201).json(createdUser);
};

module.exports = {
  createUsuario
};
