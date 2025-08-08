package com.Server.model;

import jakarta.persistence.*;

import java.util.Objects;

@Entity
@Table(name = "pet")
public class Pet {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "pet_id")
    private int petId;

    @Column(name = "name")
    private String petName;

    @Column(name = "pet_type_id")
    private int petTypeId;

    @Column(name = "owner_id")
    private int ownerId;
    // constructors

    public Pet() {}
    public Pet(int ownerId, int petTypeId, String petName, int petId) {
        this.ownerId = ownerId;
        this.petTypeId = petTypeId;
        this.petName = petName;
        this.petId = petId;
    }

    //Getters and Setters

    public int getPetId() {
        return petId;
    }
    public void setPetId(int petId) {
        this.petId = petId;
    }
    public String getPetName() {
        return petName;
    }
    public void setPetName(String petName) {
        this.petName = petName;
    }
    public int getPetTypeId() {
        return petTypeId;
    }
    public void setPetTypeId(int petTypeId) {
        this.petTypeId = petTypeId;
    }
    public int getOwnerId() {
        return ownerId;
    }
    public void setOwnerId(int ownerId) {
        this.ownerId = ownerId;
    }

    // toString, equals and hashcode overrides

    @Override
    public String toString() {
        return "Pet{" +
                "petId=" + petId +
                ", petName='" + petName + '\'' +
                ", petTypeId=" + petTypeId +
                ", ownerId=" + ownerId +
                '}';
    }
    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return getPetId() == pet.getPetId() && getPetTypeId() == pet.getPetTypeId() && getOwnerId() == pet.getOwnerId() && Objects.equals(getPetName(), pet.getPetName());
    }
    @Override
    public int hashCode() {
        return Objects.hash(getPetId(), getPetName(), getPetTypeId(), getOwnerId());
    }
// Additional methods to support the class
}
