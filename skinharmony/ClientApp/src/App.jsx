import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { YourSkincare } from './components/YourSkincare';
//import { ChakraProvider } from '@chakra-ui/react'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/YourSkincare' component={YourSkincare} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}
