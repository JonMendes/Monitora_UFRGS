const express = require('express');

const router = express.Router();

// Coisas do exemplo
// const tasksController = require('./controllers/tasksController');
// const tasksMiddleware = require('./middlewares/tasksMiddleware');

// router.get('/tasks', tasksController.getAll);
// router.post('/tasks', tasksMiddleware.validateFieldTitle, tasksController.createTask);
// router.delete('/tasks/:id', tasksController.deleteTask);
// router.put('/tasks/:id',
//   tasksMiddleware.validateFieldTitle,
//   tasksMiddleware.validateFieldStatus,
//   tasksController.updateTask,
// );

const loginController = require('./controllers/loginController');
const cadastroController = require('./controllers/cadastroController');

router.get('/login/:cartao', loginController.getUsuario);
router.get('/exists/:cartao', cadastroController.existeUsuario);
router.post('/cadastro', cadastroController.createUsuario);

module.exports = router;