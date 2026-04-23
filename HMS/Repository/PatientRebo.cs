using HMS.Data;
using HMS.Services;
using WebApplication1.Models;

namespace HMS.Repository
{
    public class PatientRebo : IPatientservice
    {
        public PatientRebo(App_Db_Contacts Contacts)
        {
            _Contacts = Contacts;
        }
        private readonly App_Db_Contacts _Contacts;
       

        public void DeletePatientById(int id)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetPatients()
        {
            throw new NotImplementedException();
        }

        public void UpdatePatientById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreatePatientById(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
