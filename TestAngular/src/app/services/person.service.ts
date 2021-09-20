import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Person } from '../components/persons/person';
import { Router } from '@angular/router';
import { environment, ApiPaths } from '../../environments/environment';


@Injectable({
  providedIn: 'root'
})
export class PersonService {
  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient, private router: Router) { }

  getAllPersons(): Observable<Person[]> {
    return this.http.get<Person[]>(this.baseUrl);
  }

  addPerson(data: Person) {
    return this.http.post(this.baseUrl + ApiPaths.addPerson, data);
  }
}
