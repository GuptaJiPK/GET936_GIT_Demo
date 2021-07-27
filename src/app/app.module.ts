import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypeComponent } from './datatype/datatype.component';
import { DirectivesComponent } from './directives/directives.component';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component';
import {FormsModule} from '@angular/forms';

//decorator:<etadat information
@NgModule({
  declarations: [//contains the list of component class
    AppComponent,
    DatatypeComponent,
    DirectivesComponent,
    TwowaybindingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
