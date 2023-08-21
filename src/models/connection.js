// const postgresql = require('pg');
// require('dotenv').config();

// const connection = postgresql.createPool({
//   host: process.env.SQL_HOST,
//   user: process.env.SQL_USER,
//   password: process.env.SQL_PASSWORD,
//   database: process.env.SQL_DB,
// });

// module.exports = connection;


const { Client } = require('pg');
require('dotenv').config();

const client = new Client({
  user: 'postgres',
  host: 'localhost',
  database: 'monitora_ufrgs',
  password: 'r3c0v4l3',
  port: '5432', // Porta padrão do PostgreSQL
});

// ==> Conexão com a Base de Dados:
client.connect()
    .then(() => {
        console.log('Conexão bem-sucedida com o PostgreSQL');
    })
    .catch(err => {
        console.error('Erro ao conectar com o PostgreSQL:', err);
    });


module.exports = { client };
// module.exports = {
//   query: (text, params) => pool.query(text, params),
// };