import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})
export class StudentListComponent {
    roster: any[] = [
    { name: 'Youssouf', age: 30, city: 'Detroit' },
    { name: 'John', age: 25, city: 'Grand Rapids' },
    { name: 'Jane', age: 28, city: 'Lansing' }
  ];
}
