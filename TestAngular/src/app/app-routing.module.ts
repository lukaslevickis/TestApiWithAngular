import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonsComponent } from './components/persons/persons.component';
import { AddPersonComponent } from './components/add-person/add-person.component';


const routes: Routes = [
  { path: 'api', component: PersonsComponent },
  { path: 'add-person', component: AddPersonComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }