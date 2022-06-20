import React, { Component } from 'react';
import { Input } from '@chakra-ui/react'
import { CUIAutoComplete } from 'chakra-ui-autocomplete'


export class YourSkincare extends Component {
  static displayName = YourSkincare.name;

  render() {
    return (
      <div>
        <h1>Your SkinCare Routine</h1>
        <span></span>

        <Input className='' placeholder='Type your skincare products here' />

      </div>
    );
  }
}
