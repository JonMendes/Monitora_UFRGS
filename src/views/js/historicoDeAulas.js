const usuario = JSON.parse(window.localStorage.getItem('dadosUsuario'));
const tbody = document.querySelector('tbody');


const fetchAulas = async () => {
  const cartao = usuario.idusuario
  const response = await fetch(`http://localhost:3333/aulasAluno/${cartao}`)
  const aulas = await response.json()
  return aulas;
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

const createRow = (aula) => {

  //const { id, title, created_at, status } = task;
  const { idaula, idaluno, idmonitor, disciplina, status, inicio, fim, modalidade, telefone, email } = aula;

  const tr = createElement('tr');
  // const td_idaula = createElement('td', idaula);
  // const td_idaluno = createElement('td', idaluno);
  const td_disciplina = createElement('td', disciplina);
  const td_idmonitor = createElement('td', idmonitor);
  const td_status = createElement('td', status);
  const td_inicio = createElement('td', inicio);
  const td_fim = createElement('td', fim);
  const td_modalidade = createElement('td', modalidade);
  const td_telefone = createElement('td', telefone);
  const td_email = createElement('td', email);

  // tr.appendChild(td_idaula);
  // tr.appendChild(td_idaluno);
  tr.appendChild(td_disciplina);
  tr.appendChild(td_idmonitor);
  tr.appendChild(td_status);
  tr.appendChild(td_inicio);
  tr.appendChild(td_fim);
  tr.appendChild(td_modalidade);
  tr.appendChild(td_telefone);
  tr.appendChild(td_email);

  return tr;
} 

const loadAulas = async () => {
  const aulas = await fetchAulas();

  tbody.innerHTML = '';

  aulas.forEach((aula) => {
    const tr = createRow(aula);
    tbody.appendChild(tr);
  });
}

loadAulas();