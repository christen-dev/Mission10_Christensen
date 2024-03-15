import React from 'react';

function Header() {
  return (
    <div className="container">
      <div className="row">
        <div className="col">
          <h1 className="mt-5 mb-3">Welcome to the Bowling League Website!</h1>
          <p className="lead">
            This website lists players in the Bowling League who play for the
            Marlins or the Sharks.
          </p>
        </div>
      </div>
    </div>
  );
}

export default Header;
