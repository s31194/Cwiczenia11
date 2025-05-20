﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial5.Models;

[Table("Prescription_Medicament")]
public class Prescription_Medicament
{
    [Key]
    [ForeignKey(nameof(Medicament))]
    public int IdMedicament { get; set; }
    [Key]
    [ForeignKey(nameof(Prescription))]
    public int IdPrescription { get; set; }
    public int Dose { get; set; }
    [MaxLength(100)]
    public string Details { get; set; }
    
    public Medicament Medicament { get; set; }
    public Prescription Prescription { get; set; }
}