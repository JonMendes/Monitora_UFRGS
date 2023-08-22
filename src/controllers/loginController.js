const loginModel = require('../models/loginModel');

const getSenha = async (request, response) => {
  const {cartao} = request.params;
  const senha = await loginModel.getSenha(cartao);
  return response.status(200).json(senha);
};

module.exports = {
  getSenha
};
