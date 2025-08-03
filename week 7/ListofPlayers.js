// src/ListofPlayers.js
import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Virat Kohli', score: 80 },
    { name: 'Rohit Sharma', score: 95 },
    { name: 'KL Rahul', score: 65 },
    { name: 'Shreyas Iyer', score: 72 },
    { name: 'Hardik Pandya', score: 50 },
    { name: 'Ravindra Jadeja', score: 90 },
    { name: 'R Ashwin', score: 68 },
    { name: 'Bumrah', score: 85 },
    { name: 'Shami', score: 60 },
    { name: 'Surya Kumar Yadav', score: 76 },
    { name: 'Ishan Kishan', score: 45 }
  ];

  const below70 = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h3>Players with score below 70</h3>
      <ul>
        {below70.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
