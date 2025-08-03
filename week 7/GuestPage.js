import React from 'react';
import Flights from './Flights';

const GuestPage = () => {
  return (
    <div>
      <h2>Welcome, Guest ✈️</h2>
      <p>Please login to book your tickets.</p>
      <Flights />
    </div>
  );
};

export default GuestPage;
