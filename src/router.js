const express = require('express');

const router = express.Router();

const loginController = require('./controllers/loginController');
const cadastroController = require('./controllers/cadastroController');
const aulasController = require('./controllers/aulasController');

router.get('/login/:cartao', loginController.getUsuario);
router.get('/exists/:cartao', cadastroController.existeUsuario);
router.post('/cadastro', cadastroController.createUsuario);
router.post('/solicitarAula', aulasController.solicitarAula);
router.get('/aulasAluno/:cartao', aulasController.getAulasAluno);
router.get('/aulasMonitor/:cartao', aulasController.getAulasMonitor);

module.exports = router;