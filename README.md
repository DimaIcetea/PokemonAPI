# Project Pokemon API

Welcome to the Pokemon API project! This repository serves as an API for retrieving information about Pokémon through HTTP requests.

# Usage
## Getting Started
To get started with using the Pokemon API, follow these steps:

Clone the repository to your local machine:
```
git clone https://github.com/DimaIcetea/Pokemon
```
Navigate to the project directory:
```
cd Pokemon
```
Install dependencies:
```
npm install
```
Start the server:
```
npm start
```
# Making Requests
Once the server is running, you can make HTTP requests to retrieve information about Pokémon.

## Get Pokémon by ID
To retrieve information about a Pokémon by its ID, make a GET request to the following endpoint:
```
GET /pokemon/{id}
```
Replace {id} with the ID of the Pokémon you want to retrieve.

## Get Pokémon by Name
To retrieve information about a Pokémon by its name, make a GET request to the following endpoint:
```
GET /pokemon/{name}
```
Replace {name} with the name of the Pokémon you want to retrieve.

## Example
Here's an example of how you can retrieve information about a Pokémon:
```
curl http://localhost:3000/pokemon/1
```
This will return information about Pikachu.

# Contributing
Contributions are welcome! If you have any suggestions, bug reports, or would like to contribute code, please open an issue or submit a pull request.

# Сontact
If you have any questions or need further assistance, feel free to contact me at haky.gamer050@gmail.com




























