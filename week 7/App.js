import React, { useState } from 'react';
import './App.css';
import GuestPage from './GuestPage'; // or './components/GuestPage' if it's in a folder
import UserPage from './UserPage';   // or './components/UserPage' if it's in a folder

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  return (
    <div className="App">
      <h1>✈️ Ticket Booking App</h1>

      {isLoggedIn ? (
        <>
          <button onClick={handleLogout}>Logout</button>
          <UserPage />
        </>
      ) : (
        <>
          <button onClick={handleLogin}>Login</button>
          <GuestPage />
        </>
      )}
    </div>
  );
}

export default App;
