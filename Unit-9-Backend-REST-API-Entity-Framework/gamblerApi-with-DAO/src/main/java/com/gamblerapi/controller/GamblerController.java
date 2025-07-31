package com.gamblerapi.controller;

import com.gamblerapi.dao.GamblerDAO.GamblerMemoryDao;
import com.gamblerapi.model.Gambler;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class GamblerController {
    private final GamblerMemoryDao gamblerDao;
    public GamblerController() {
        this.gamblerDao = new GamblerMemoryDao();
    }
    @GetMapping("/gamblers")
    public List<Gambler> GetAllGamblers() {
        return this.gamblerDao.getGamblers();
    }
    @GetMapping("/gambler/{id}")
    public Gambler GetGamblerById(@PathVariable int id) {
        return this.gamblerDao.getGambler(id);
    }
    @GetMapping("/gamblers/search")
    public Gambler GetGambler(@RequestParam String name) {
        return  this.gamblerDao.getGamblerByName(name);
    }
}
