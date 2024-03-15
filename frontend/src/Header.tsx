import React from 'react';
import logo from './bowlingleague.webp';

function Header() {
  return (
    <header className="row navbar">
      <div className="col">
        <img src={logo} className="logo" alt="logo" height={200} />
      </div>
      <div className="col subtitle">
        <h1>Bowling League</h1>
      </div>
    </header>
  );
}

export default Header;
