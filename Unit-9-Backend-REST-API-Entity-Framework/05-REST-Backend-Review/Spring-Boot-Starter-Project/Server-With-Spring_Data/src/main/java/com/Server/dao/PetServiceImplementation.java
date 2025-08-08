package com.Server.dao;

import com.Server.model.Pet;
import org.springframework.stereotype.Service;

import java.util.List;
@Service
public class PetServiceImplementation implements IPet {

    PetRepository thePetRepository;

    public PetServiceImplementation(PetRepository thePetRepository) {
        this.thePetRepository = thePetRepository;
    }

    @Override
    public List<Pet> getAllPets() {
        return List.of();
    }

    @Override
    public Pet returnPet(int pkey) {
        return null;
    }

    @Override
    public Pet addPet(Pet aPet) {
        return null;
    }

    @Override
    public Pet updatePet(Pet aPet) {
        return null;
    }

    @Override
    public void deletePet(int priKey) {

    }
}
