let body = document.querySelector("#test");

let building = ["car", "house", "door"];

building.push("pool");
// ['car', 'house', 'door', 'pool']

building.pop();
// ['car', 'house', 'door']

building.building.unshift("car");

delete building[2];

for (let i = 0; i < building.length(); i++) {
  body.innerText += building[i] + ",";
}
