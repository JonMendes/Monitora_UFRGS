const express = require('express');

const router = express.Router();

const usuarioController = require('./controllers/usuarioController');
const cadastroController = require('./controllers/cadastroController');
const aulasController = require('./controllers/aulasController');
const disciplinaController = require('./controllers/disciplinaController');

// gets
router.get('/usuario/:cartao', usuarioController.getUsuario);
router.get('/exists/:cartao', cadastroController.existeUsuario);
router.get('/aulasAluno/:cartao', aulasController.getAulasAluno);
router.get('/aulasMonitor/:cartao', aulasController.getAulasMonitor);
router.get('/disciplina', disciplinaController.getDisciplina);

// posts
router.post('/cadastro', cadastroController.createUsuario);
router.post('/solicitarAula', aulasController.solicitarAula);

module.exports = router;