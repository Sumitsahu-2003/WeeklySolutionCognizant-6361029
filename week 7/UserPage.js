import React from 'react';
import Flights from './Flights';

const UserPage = () => {
  return (
    <div>
      <h2>Welcome, User 👤</h2>
      <p>You are logged in. You can now book your tickets.</p>
      <Flights />
      <button style={{ marginTop: '10px' }}>Book Ticket</button>
    </div>
  );
};

export default UserPage;
