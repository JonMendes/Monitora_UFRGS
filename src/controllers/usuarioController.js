const usuarioModel = require('../models/usuarioModel');

const getUsuario = async (request, response) => {
  const {cartao} = request.params;
  const user = await usuarioModel.getUsuario(cartao);
  return response.status(200).json(user);
};

module.exports = {
  getUsuario
};
