package com.waycare.repository;

import com.waycare.model.categoria;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CategoriaRepository extends JpaRepository<categoria, Long> {
}
