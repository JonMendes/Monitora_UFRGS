const loginModel = require('../models/loginModel');

const getUsuario = async (request, response) => {
  const {cartao} = request.params;
  const user = await loginModel.getUsuario(cartao);
  return response.status(200).json(user);
};

module.exports = {
  getUsuario
};
