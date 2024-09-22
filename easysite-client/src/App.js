// src/App.js
import React, { useState } from "react";
import Register from "./components/Register";
import Login from "./components/Login";

const App = () => {
  const [showLogin, setShowLogin] = useState(true);

  return (
    <div className="App">
      <button onClick={() => setShowLogin(!showLogin)}>
        {showLogin ? "Go to Register" : "Go to Login"}
      </button>
      {showLogin ? <Login /> : <Register />}
    </div>
  );
};

export default App;
