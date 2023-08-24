const usuario = JSON.parse(window.localStorage.getItem('dadosUsuario'));
const tbody = document.querySelector('tbody');
const barra = document.querySelector('p');
const disciplinas = usuario.disciplinasmatriculadas

const createRow = async (m) => {

    const response = await fetch(`http://localhost:3333/login/${m}`);
    const monitor = await response.json();

    const { id, nome} = monitor;
  
    const tr = createElement('tr');
    const td_id = createElement('td', id);
    const td_nome = createElement('td', nome);
  
    tr.appendChild(td_id);
    tr.appendChild(td_nome);

    return tr;
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

const createSelect = async() => {

    const options = ""
    disciplinas.forEach((discp) => {
        options = options +"<option value="+ discp +">"+ discp +"</option>"
      });

    const select = createElement('select', '', options);
    
    return select;
}

  const fetchMonitores = async (e) => {
    const monitores = await fetchTasks(`http://localhost:3333/disciplina/${e}`);
  
    tbody.innerHTML = '';
  
    monitores.forEach((monitor) => {
      const tr = createRow(monitor);
      tbody.appendChild(tr);
    });
}

barra.appendChild(createSelect());

const barra_select = document.querySelector('select')
barra_select.addEventListener("click", fetchMonitores(barra_select.value))
