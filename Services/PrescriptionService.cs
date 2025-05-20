using Tutorial5.DTOs;
using Tutorial5.Interfaces;
using Tutorial5.Models;

namespace Tutorial5.Services;

public class PrescriptionService : IPrescriptionService
{
    public Task AddPrescriptionAsync(CreatePrescriptionRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Patient> GetPatientDetailsAsync(int idPatient)
    {
        throw new NotImplementedException();
    }
}