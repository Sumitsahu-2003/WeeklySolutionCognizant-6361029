// src/IndianPlayers.js
import React from 'react';

const IndianPlayers = () => {
  const allPlayers = ['Virat', 'Rohit', 'Rahul', 'Jadeja', 'Ashwin', 'Shami', 'Bumrah', 'Surya', 'Pant', 'Hardik'];

  // Destructuring into even and odd team
  const oddTeam = allPlayers.filter((_, i) => i % 2 === 0);
  const evenTeam = allPlayers.filter((_, i) => i % 2 !== 0);

  // Merging two arrays using spread operator
  const T20players = ['Virat', 'Rohit', 'Surya'];
  const RanjiTrophy = ['Pujara', 'Rahane', 'Shaw'];
  const allCricketers = [...T20players, ...RanjiTrophy];

  return (
    <div>
      <h2>Odd Team Players</h2>
      <ul>
        {oddTeam.map((p, i) => <li key={i}>{p}</li>)}
      </ul>

      <h2>Even Team Players</h2>
      <ul>
        {evenTeam.map((p, i) => <li key={i}>{p}</li>)}
      </ul>

      <h2>All Merged Cricketers (T20 + Ranji)</h2>
      <ul>
        {allCricketers.map((p, i) => <li key={i}>{p}</li>)}
      </ul>
    </div>
  );
};

export default IndianPlayers;
