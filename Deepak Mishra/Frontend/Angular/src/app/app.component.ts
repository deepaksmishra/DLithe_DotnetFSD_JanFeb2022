import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
//string interpolation
  title = 'Angular TUTS';
  //property binding
  public image ="/assets/images/hils.jpg"
//two way binding

public value =" "

//event binding

onclick(){
  alert("Click")

}

}
