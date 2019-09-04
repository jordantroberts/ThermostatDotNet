import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Thermostat } from './components/Thermostat';


export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Thermostat} />
            <Route exact path='/thermostat' component={Thermostat} />
      </Layout>
    );
  }
}
