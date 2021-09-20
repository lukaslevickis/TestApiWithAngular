import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PersonService } from 'src/app/services/person.service';
import { PERSONS } from './mock-persons';
import { Person } from './person';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.css']
})
export class PersonsComponent implements OnInit {
  persons: Person[] = [];

  constructor(public personService: PersonService) { }

  ngOnInit(): void {
    this.personService.getAllPersons().subscribe((data: Person[]) => {
      this.persons = data;
      console.log(data);
    })
  }

}
