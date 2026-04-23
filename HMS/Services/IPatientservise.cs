using WebApplication1.Models;

namespace HMS.Services
{
    public interface IPatientservice
    {
        List<Patient> GetPatients();

        Patient GetPatientById(int id);

        void UpdatePatientById(int id);

        void DeletePatientById(int id);

        void CreatePatientById(Patient patient);

    }
}