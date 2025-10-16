package com.waycare.repository;

import com.waycare.model.reporte;
import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface ReporteRepository extends JpaRepository<reporte, Long> {

    List<reporte> findByEstado(String estado);

    List<reporte> findByUtilizador_Id(Long utiId);
}
