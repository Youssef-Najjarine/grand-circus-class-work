import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule, CommonModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Data to be shared with the Angular when processing the web page
  buttonClicked = false
  firstName = ""     // hold the data from first name from the form
  lastName = ""      // hold the data from last name from the form
  birthday = ""      // hold the data from birthday from the form
  foodPreference = ""
  emailAddress = ""
  sendEmail = ""
  // A checkbox control may have multiple values (many checkboxes can be checked)
  // Sports is specified as a checkbox it's data will be returned as an array
  // With each element in the array corresponding to a choice
  // Checkbox need to be included in the html a individual element
  // More tomorrow
  //sports : any[] 
  sports: any[] = [
    { name: "European Football", value:"Soccer" },
    { name: "Cricket", value:"Cricket" },
    { name: "American Football", value:"Football" },
    { name: "Baseball", value:"Baseball" },
    { name: "Hockey", value:"Hockey" },
    { name: "Other", value:"Other Sport" },
    { name: "None", value: "None"}
  ]
 // Methods to handle interactions with the html/web page
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the First Name field`)
    console.log(`You entered ${this.lastName} in the Last Name field`)
    console.log(`You entered ${this.emailAddress} in the email field`)
    console.log(`You entered ${this.sports} as sports you like`)
    console.log(this.sports)
    console.table(this.checkBoxResult)
    this.checkBoxResult.forEach((aBox) => console.log("You like " + aBox.name))
  }
  get checkBoxResult() {
    return this.sports.filter((aCheckBox) => aCheckBox.checked)
  }
}