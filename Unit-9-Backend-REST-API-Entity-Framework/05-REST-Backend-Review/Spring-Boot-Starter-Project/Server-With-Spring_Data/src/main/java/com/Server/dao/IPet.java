package com.Server.dao;

import com.Server.model.Pet;

import java.util.List;

public interface IPet {
    public List<Pet> getAllPets();

    public Pet returnPet(int pkey);

    public Pet addPet(Pet aPet);

    public Pet updatePet(Pet aPet);

    public void deletePet(int priKey);
}
