using Tutorial5.DTOs;
using Tutorial5.Models;

namespace Tutorial5.Interfaces;

public interface IPrescriptionService
{
    Task AddPrescriptionAsync(CreatePrescriptionRequest request);
    Task<Patient> GetPatientDetailsAsync(int idPatient);
}