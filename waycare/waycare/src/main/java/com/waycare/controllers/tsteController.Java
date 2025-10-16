package com.waycare.controller;

import org.springframework.web.bind.annotation.*;
import java.util.List;
import com.waycare.model.Utilizador;
import com.waycare.repository.UtilizadorRepository;

@RestController
@RequestMapping("/api/utilizadores")
public class TestController {
    private final UtilizadorRepository repo;

    public TestController(UtilizadorRepository repo) { this.repo = repo; }

    @GetMapping
    public List<Utilizador> listar() {
        return repo.findAll();
    }
}
