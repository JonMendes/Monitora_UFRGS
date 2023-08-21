const { client } = require('./connection');

const getAll = async () => {
  const tasks = await client.query('SELECT * FROM tasks');
  
  return tasks;
};

const createTask = async (task) => {
  const { title } = task;
  const dateUTC = new Date(Date.now()).toUTCString();

  const query = 'INSERT INTO tasks(title, status, created_at) VALUES ($1, $2, $3)';

  const createdTask = await client.query(query, [title, 'pendente', dateUTC]);

  return {insertId: createdTask.insertId};
};

const deleteTask = async (id) => {
  const removedTask = await client.query('DELETE FROM tasks WHERE id = $1', [id]);

  return removedTask;
};

const updateTask = async (id, task) => {
  const { title, status } = task;
  
  const query = 'UPDATE tasks SET title = $1, status = $2 WHERE id = $3';

  const updatedTask = await client.query(query, [title, status, id]);

  return updatedTask;
};

module.exports = {
  getAll,
  createTask,
  deleteTask,
  updateTask,
};
