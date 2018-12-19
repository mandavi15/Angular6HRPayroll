import { Component, OnInit } from '@angular/core';
//import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
    selector: 'designation',
    template: 'My good name is {{name}}'
})

export class DesignationComponent {

    name: string = "amarjeet";
}