import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;


  render() {

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
      </div>
    );
  }

}
