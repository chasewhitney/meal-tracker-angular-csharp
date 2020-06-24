import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  baseUrl = 'http://localhost:5000/api/meals';
  meals: any = [];
  registerMode = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    // this.getMeals();
  }

  getMeals() {
    console.log('gonna get meals');
    this.http.get(this.baseUrl).subscribe(response => {
      this.meals = response;
      console.log('got meals:', this.meals);
    }, error => {
      console.log(error);
    });
  }

  registerToggle() {
    this.registerMode = true;
  }

  cancelRegisterMode() {
    this.registerMode = false;
  }

}
