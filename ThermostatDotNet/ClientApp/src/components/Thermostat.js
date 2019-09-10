
import React, { Component } from 'react';
import "./Thermostat.css";
import ThermostatImage from './ThermostatImage.jpg';

export class Thermostat extends Component {
    constructor(props) {
        super(props);
        this.state = { temp: 20 };
    }


    increaseTemp() {
       fetch("api/Thermostat/Increase?newTemp=" + encodeURIComponent(this.state.temp))
     .then(response => response.text())
      .then(data => {
          this.setState({ temp: data });

      });
    }

     resetTemp() {
       fetch("api/Thermostat/Reset/")
      .then(response => response.text())
      .then(data => {
        this.setState({ temp: data });
      });
    }

    decreaseTemp() {
       fetch("api/Thermostat/Decrease?newTemp=" + encodeURIComponent(this.state.temp))
      .then(response => response.text())
      .then(data => {
       this.setState({ temp: data });
      });
    }
    

  render () {
    return (
        <div>
         <center>
             <h1>Thermostat</h1>
                <p>The temperature is: {this.state.temp}°C</p>
                <p> <img className="image" src={ThermostatImage} alt={"thermostatimage"}/></p>
                     <button className="button" onClick={() => this.resetTemp()}>Reset</button>
                     <button className="button" onClick={() => this.increaseTemp()}>Increase</button>
                <button className="button" onClick={() => this.decreaseTemp()}>Decrease</button>
          </center>
        </div>
    );
  }
}
