const https = require("https");
const user = "hgrafa";
const enviroment = {
  APIroute: "https://api.github.com",
};
// https://api.github.com/users/chandelima

const requestRoute = `${enviroment.APIroute}/users/${user}`;
console.log(requestRoute);

https.get(requestRoute, (response) => {
  console.log(response.statusCode);
});
