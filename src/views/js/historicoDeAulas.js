const usuario = JSON.parse(window.localStorage.getItem('dadosUsuario'));
const tbody = document.querySelector('tbody');
//const addForm = document.querySelector('.add-form');
//const inputTask = document.querySelector('.input-task');

const fetchTasks = async () => {
  const cartao = usuario.cartao
  const response = await fetch(`http://localhost:3333/getAulasAluno/${cartao}`)
  const tasks = await response.json()
  return tasks;
}

const createRow = (task) => {

  //const { id, title, created_at, status } = task;
  const { idaula, idaluno, idmonitor, disciplina, status, inicio, fim, modalidade } = task;

  const tr = createElement('tr');
  const td_idaula = createElement('td', idaula);
  const td_idaluno = createElement('td', idaluno);
  const td_idmonitor = createElement('td', idmonitor);
  const td_disciplina = createElement('td', disciplina);
  const td_status = createElement('td', status);
  const td_inicio = createElement('td', inicio);
  const td_modalidade = createElement('td', modalidade);
  const td_fim = createElement('td', fim);

  tr.appendChild(td_idaula);
  tr.appendChild(td_idaluno);
  tr.appendChild(td_idmonitor);
  tr.appendChild(td_disciplina);
  tr.appendChild(td_status);
  tr.appendChild(td_inicio);
  tr.appendChild(td_modalidade);
  tr.appendChild(td_fim);

  return tr;
}

const loadTasks = async () => {
  const tasks = await fetchTasks();

  tbody.innerHTML = '';

  tasks.forEach((task) => {
    const tr = createRow(task);
    tbody.appendChild(tr);
  });
}

loadTasks();