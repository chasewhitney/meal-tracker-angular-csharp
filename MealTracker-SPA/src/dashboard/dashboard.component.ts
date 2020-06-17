import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  baseUrl = 'http://localhost:5000/api/meals';
  meals: any = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getMeals();
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

}
