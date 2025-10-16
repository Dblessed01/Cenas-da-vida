package com.waycare.model;

import jakarta.persistence.*;
import lombok.*;
import java.time.LocalDateTime;

@Entity
@Table(name = "reporte")
@Data
@NoArgsConstructor
@AllArgsConstructor
public class reporte {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "rep_id")
    private Long id;

    @ManyToOne
    @JoinColumn(name = "rep_uti_id")
    private utlizador utilizador;

    @ManyToOne
    @JoinColumn(name = "rep_obs_id")
    private obstaculo obstaculo;

    @ManyToOne
    @JoinColumn(name = "rep_loc_id")
    private localizacao localizacao;

    @Column(name = "rep_data")
    private LocalDateTime data;

    @Column(name = "rep_estado")
    private String estado;

    @Column(name = "rep_comentario")
    private String comentario;
}

