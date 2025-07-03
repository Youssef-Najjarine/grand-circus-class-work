import { Component } from '@angular/core';
import { NavBar } from '../nav-bar/nav-bar';
@Component({
  selector: 'home-page',
  standalone: true,
  imports: [NavBar],
  templateUrl: './homepage.html',
  styleUrl: './homepage.css'
})
export class Homepage {

}
