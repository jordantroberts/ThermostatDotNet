
import React, { Component } from 'react';

export class Thermostat extends Component {
    constructor(props) {
        super(props);
        this.state = { temp: "" };
  

    fetch("api/Thermostat/GetTemp/")
      .then(response => response.text())
      .then(data => {
        this.setState({ temp: data });
      });
    }

    increaseTemp() {
          fetch("api/Thermostat/Increase/")
      .then(response => response.text())
      .then(data => {
        this.setState({ temp: data });
      });
    }
    
 
  render () {
    return (
      <div>
        <h1>Thermostat</h1>
            <p>The temperature is: {this.state.temp}°C</p>
        
         <button onClick={() => this.increaseTemp()}>Increase</button>

            </div>
    );
  }
}


