// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';
import { PetInfo } from '../interfaces/pet-info';
@Injectable({
  providedIn: 'root'
})
export class PetService {
  petData: PetInfo[] = []
  constructor() { 
    this.petData.push({name: "jenna", type: "dog", gender: "male"})
  }
}
