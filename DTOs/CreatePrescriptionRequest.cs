namespace Tutorial5.DTOs;

public class CreatePrescriptionRequest
{
    public string PatientFirstName { get; set; }
    public string PatientLastName { get; set; }

    public int IdDoctor { get; set; }

    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }

    public List<CreateMedicamentDto> Medicaments { get; set; }

    public class CreateMedicamentDto
    {
        public int IdMedicament { get; set; }
        public int Dose { get; set; }
        public string Description { get; set; }
    }
}