package com.waycare.repository;
import com.waycare.model.obstaculo;

import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface ObstaculoRepository extends JpaRepository<obstaculo, Long> {

    // Podes criar métodos automáticos baseados em nomes
    List<obstaculo> findByGrauPerigo(String grauPerigo);

    List<obstaculo> findByCategoria_Nome(String nomeCategoria);
}

