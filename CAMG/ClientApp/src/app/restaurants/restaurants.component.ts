import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-restaurants',
  templateUrl: './restaurants.component.html',
  styleUrls: ['./restaurants.component.css'],
})
export class RestaurantsComponent {
  public restaurants: Restaurant[] = []
  public searchBoxInput: string = "";

  constructor(private http: HttpClient) {
    this.http.get<Restaurant[]>('http://localhost:60126/restaurant').subscribe(result => {
      this.restaurants = result;
    }, error => console.error(error));
  }

  public onSearchButtonClick() {
    let params = new HttpParams().set('keyword', this.searchBoxInput);
    this.http.get<Restaurant[]>('http://localhost:60126/restaurant/getbykeyword', { params: params }).subscribe(result => {
      this.restaurants = result;
    }, error => console.error(error));
  }

  public ClearAndReset() {
    this.searchBoxInput = "";
    this.http.get<Restaurant[]>('http://localhost:60126/restaurant').subscribe(result => {
      this.restaurants = result;
    }, error => console.error(error));
  }
}

interface Restaurant {
  address: Adress;
  borough: string;
  cuisine: string;
  name: string;
}

interface Adress {
  building: number;
  coordinates: number[];
  street: string;
  zipcode: number;
}
