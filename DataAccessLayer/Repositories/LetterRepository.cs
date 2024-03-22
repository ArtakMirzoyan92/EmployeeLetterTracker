using DataAccessLayer.DbContexts;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Repositories
{
    public class LetterRepository : ILetterRepository
    {
        private readonly EmployeeLetterDbContext _dbContext;        
       
        public LetterRepository(EmployeeLetterDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddLetter(EmployeeLetter letter)
        {
            _dbContext.EmployeeLetters.Add(letter);
            _dbContext.SaveChanges();
        }

    }

}
