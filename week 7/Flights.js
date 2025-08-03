import React from 'react';

const Flights = () => {
  const flights = [
    { id: 1, from: 'Delhi', to: 'Mumbai', time: '10:00 AM', price: 4500 },
    { id: 2, from: 'Bangalore', to: 'Chennai', time: '2:00 PM', price: 3200 },
    { id: 3, from: 'Kolkata', to: 'Hyderabad', time: '6:30 PM', price: 3900 }
  ];

  return (
    <div>
      <h3>🛫 Available Flights</h3>
      <ul>
        {flights.map((flight) => (
          <li key={flight.id}>
            {flight.from} → {flight.to} | Time: {flight.time} | ₹{flight.price}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Flights;
