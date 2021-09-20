import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { PersonService } from 'src/app/services/person.service';
import { Person } from '../persons/person';
import { ApiPaths, environment } from '../../../environments/environment';

@Component({
  selector: 'app-add-person',
  templateUrl: './add-person.component.html',
  styleUrls: ['./add-person.component.css']
})
export class AddPersonComponent implements OnInit {
  posData = {} as Person;
  personForm = this.formBuilder.group({
    name: '',
    surname: ''
  });

  constructor(
    private personService: PersonService,
    private formBuilder: FormBuilder,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
        this.posData.name = this.personForm.value.name;
        this.posData.surname = this.personForm.value.surname;
    this.personService.addPerson(this.posData).subscribe(x => {
      this.router.navigate([ApiPaths.base]);
    });
  }

}
