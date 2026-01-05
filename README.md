# PokemonApi

<p align="center">
  <img src="./_resources/pokemon-logo3.PNG" alt="Pokemon" />
</p>

Welcome to the **pokemon** App!

This is a project designed to demonstrate combining a .NET Web API with a React frontend. 

It allows users to view a list of pokemon from an external API!

## Requirements

- [x] This is an application where you should present data coming from a .NET WebAPI using React.
- [x] Your application can only have GET requests.
- [x] You cannot use AXIOS to fetch the data, you have to use JS Fetch API
- [x] You should create an API of your choice, with a model representing a single table.
- [x] One of the properties of your API's model should be imageUrl, with a link to pictures that will be shown by the react app.
- [x] You can choose whatever ORM you want: Dapper, EF, ADO.NET.
- [x] Your app needs to have a list of records and a page to visualise an individual record.
- [x] Your app should show a 'Loading Data...' message while the request hasn't been completed.
- [x] If there's a server error, the user should be informed.

## Features

- **Loading**: When the frontend application starts, it will show a Loading Data message.
- **Error**: If there is an error when fetching the api data, it will show an Error message.
- **List View**: When the api data has been fetched, a list of pokemon will be displayed.
- **API Methods**: Get methods are exposed within the api application.
- **Database Seeding**: When the backend application start, it will insert some initial data if no data is added.

## Technologies

- .NET
- React
- CSS
- JavaScript
- Entity Framework Core
- SQL Server

## Getting Started

The InitialCreate database migration has been created. You will need to 

### Prerequisites

- .NET 8 SDK.
- A code editor like Visual Studio or Visual Studio Code.
- SQL Server.
- SQL Server Management Studio (optional).
- Node.js
- NPM

### Installation

1. Clone the repository:
	- `git clone https://github.com/Jinboi/React.ExternalApi.git`

2. Navigate to the API project directory:
	- `cd React.PokemonApi\React.PokemonApi`
	
3. Configure the application:
	- Update the connection string in `appsettings.json` if you require.
	
4. Build the application using the .NET CLI:
	- `dotnet build`

5. Navigate to the Web project directory:
	- `cd React.PokemonApi\react.pokemonweb`

6. Install dependencies:
	- `npm install`

### Running the Application

1. Run the API application using the .NET CLI in the API project directory:
	- `dotnet run`

2. Start the development server in the Web project directory:
	- `npm start`

## Usage

Once the Web application is running:

- Loading Data message will show while fetch api is run.
- View a list of pokemon.
- If Error message is returned, check API is running, check port running on.

### Loading Page

![loading page](./_resources/pokemon-loading-image.PNG)


### pokemon List

![Pokemon list](./_resources/pokemon-loading-success.PNG)

### Error Page

![error page](./_resources/pokemon-loading-fail.PNG)

## How It Works

- **API Integration**: Fetch is used to call the External API.
- **Seed Data**: Seed Data will be added to the database if there is no data in the database.
- **Data Access**: Interaction with the database is via Entity Framework Core.

---
***Pokemon is everything!***
