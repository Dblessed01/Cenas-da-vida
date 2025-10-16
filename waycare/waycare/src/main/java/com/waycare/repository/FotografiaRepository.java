package com.waycare.repository;

import com.waycare.model.fotografia;
import org.springframework.data.jpa.repository.JpaRepository;
import java.util.List;

public interface FotografiaRepository extends JpaRepository<fotografia, Long> {

    List<fotografia> findByReporte_Id(Long repId);
}
