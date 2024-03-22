using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface ILetterRepository
    {       
        void AddLetter(EmployeeLetter letter);       
    }
}
