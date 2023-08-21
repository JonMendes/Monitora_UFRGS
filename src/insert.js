const { client } = require("./models/connection");

async function insertData() {
  const [title, status, created_at] = process.argv.slice(2);
  const res = await client.query(
    "INSERT INTO tasks (title, status, created_at) VALUES ($1, $2, $3)",
    [title, status, created_at]
  );
  console.log(`Added a shark with the name ${title}`);
}

insertData();