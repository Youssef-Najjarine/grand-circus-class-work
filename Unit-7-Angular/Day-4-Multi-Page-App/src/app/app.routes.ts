import { Routes }        from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { SampleFormComponent } from './components/sample-form/sample-form.component';
import { StateSealsComponent } from './components/state-seals/state-seals.component';
import { StudentListComponent } from './components/student-list/student-list.component';
export const routes: Routes = [
    {path: ' ', redirectTo: '/home', pathMatch: 'full' },
    {path: 'home', component: HomeComponent},
    {path: 'sample-form', component: SampleFormComponent},
    {path: 'state-seals', component: StateSealsComponent},
    {path: 'student-list', component: StudentListComponent}
];
