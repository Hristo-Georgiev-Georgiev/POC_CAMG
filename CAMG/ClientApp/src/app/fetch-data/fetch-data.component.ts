import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public shipwrecks: Shipwrecks[] = [];

  constructor(http: HttpClient) {
    http.get<Shipwrecks[]>('http://localhost:60126/shipwrecks').subscribe(result => {
      this.shipwrecks = result;
    }, error => console.error(error));
  }
}

interface Shipwrecks {
  id: string;
  feature: string;
  latitude: number;
  longitude: number;
}
