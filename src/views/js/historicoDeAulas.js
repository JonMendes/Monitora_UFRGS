const usuario = JSON.parse(window.localStorage.getItem('dadosUsuario'));
const tbody = document.querySelector('tbody');


const fetchTasks = async () => {
  const cartao = usuario.idusuario
  const response = await fetch(`http://localhost:3333/aulasAluno/${cartao}`)
  const tasks = await response.json()
  return tasks;
}

const createElement = (tag, innerText = '', innerHTML = '') => {
  const element = document.createElement(tag);

  if (innerText) {
    element.innerText = innerText;
  }

  if (innerHTML) {
    element.innerHTML = innerHTML;
  }

  return element;
}

const createRow = (task) => {

  //const { id, title, created_at, status } = task;
  const { idaula, idaluno, idmonitor, disciplina, status, inicio, fim, modalidade } = task;

  const tr = createElement('tr');
  // const td_idaula = createElement('td', idaula);
  // const td_idaluno = createElement('td', idaluno);
  const td_disciplina = createElement('td', disciplina);
  const td_idmonitor = createElement('td', idmonitor);
  const td_status = createElement('td', status);
  const td_inicio = createElement('td', inicio);
  const td_fim = createElement('td', fim);
  const td_modalidade = createElement('td', modalidade);

  // tr.appendChild(td_idaula);
  // tr.appendChild(td_idaluno);
  tr.appendChild(&nbsp);
  tr.appendChild(td_disciplina);
  tr.appendChild(&nbsp);
  tr.appendChild(td_idmonitor);
  tr.appendChild(&nbsp);
  tr.appendChild(td_status);
  tr.appendChild(&nbsp);
  tr.appendChild(td_inicio);
  tr.appendChild(&nbsp);
  tr.appendChild(td_fim);
  tr.appendChild(&nbsp);
  tr.appendChild(td_modalidade);

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