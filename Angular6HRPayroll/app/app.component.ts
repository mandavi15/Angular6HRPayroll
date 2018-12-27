//import { Component } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1>`,
})

export class AppComponent { name = 'Angular'; }
