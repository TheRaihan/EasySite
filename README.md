# EasySite
This system built with **.NET 6**, **MongoDB**, and **React**.

## Features

- User registration with secure password hashing
- User login with authentication
- Front end created with React
- RESTful API built with .NET 6
- MongoDB as the database

## Technologies Used

- **Backend**: .NET 6, MongoDB
- **Frontend**: React, Axios
- **Database**: MongoDB
- **Authentication**: BCrypt for password hashing

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (for the React front end)
- [MongoDB](https://www.mongodb.com/try/download/community) installed and running locally or on a remote server

## Getting Started

### Backend Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/user-auth-system.git
   cd EasySite
   ```
2. **Install the required .NET packages**:

   ```bash
   dotnet restore
   ```
3. **Configure MongoDB**:
    ```bash
    {
    "MongoDBSettings": {
      "ConnectionString": "mongodb://localhost:27017",
      "DatabaseName": "UserAuthDB"
      }
    }
    ```
4. **Run backend**:

   ```bash
   dotnet run
   ```
### Frontend Setup

1. **Navigate to the React front end:**:
   ```bash
   cd easysite-client
   ```

2. **Install dependencies**:

   ```bash
   npm install
   ```
3. **Run React app**:

   ```bash
   npm start
   ```
  The front end should be running on http://localhost:3000.

## How to Use
- Register: Visit http://localhost:3000 and fill in the registration form to create a new account.
- Login: Use the login form to access your account.
## API Endpoints
- POST /api/auth/register: Register a new user
- POST /api/auth/login: Authenticate an existing user
## CORS Configuration
Ensure CORS is enabled in the .NET backend (Program.cs) to allow communication with the React app:
  
  ```bash
  builder.Services.AddCors(options =>
  {
      options.AddPolicy("AllowReactApp",
          policy => policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
  });
  ```
Run the .NET app with CORS enabled:
  ```bash
  app.UseCors("AllowReactApp");
  ```
## Folder Structure
  ```bash
  EasySite/
│
├── easysite-client/   # React front-end
│   ├── src/
│   │   ├── components/  # React components (Login, Register)
│   │   ├── App.js       # Main application component
│   │   └── index.js     # Entry point for React app
│
├── Controllers/        # .NET API controllers
├── Models/             # User model
├── Repositories/       # User repository (database logic)
├── Services/           # User services (business logic)
└── Program.cs          # .NET app entry point
```

## Troubleshooting
Make sure MongoDB is running on your local machine or correctly configured for a remote database.
If you encounter issues with Axios requests, verify that CORS is correctly set up in the backend.
