import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core'
import { FormsModule,ReactiveFormsModule } from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    //כל קומפוננטה חייבת להיות כאן
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, FormsModule, AppRoutingModule
  ],
  providers: [//עבור כל סרויס],
  bootstrap: [AppComponent]
})
export class AppModule { }
