
import React, { Component } from 'react';

export class Thermostat extends Component {
    constructor(props) {
        super(props);
        this.state = { temperature: "" };
        
    }

  render () {
    return (
      <div>
        <h1>Thermostat</h1>
        <p>The temperature is:</p>
      </div>
    );
  }
}

