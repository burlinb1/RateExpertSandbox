import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'city',
    templateUrl: './city.component.html'
})
export class CityComponent {
    public cities: City[];

    constructor(http: Http) {
        http.get('/api/City/').subscribe(result => {
            this.cities = result.json() as City[];
        });
    }
}

interface City {
    id: number;
    name: string;
}