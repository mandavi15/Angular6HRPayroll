
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent }  from './app.component';
import { DesignationComponent } from './HR/designation.component';

@NgModule({
    imports: [BrowserModule,
        ReactiveFormsModule, HttpModule ],
    declarations: [AppComponent, DesignationComponent],
    bootstrap: [AppComponent, DesignationComponent]
})
export class AppModule { }

