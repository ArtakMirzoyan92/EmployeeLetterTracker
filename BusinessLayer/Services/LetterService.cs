using AutoMapper;
using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using DataAccessLayer.DbContexts;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;

namespace BusinessLayer.Services
{
    public class LetterService : ILetterService
    {
        private readonly ILetterRepository _letterRepository;
        private readonly IMapper _mapper;

        public LetterService(ILetterRepository letterRepository, IMapper mapper)
        {
            _letterRepository = letterRepository ?? throw new ArgumentNullException(nameof(mapper));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public bool Add(LetterForCreate letter)
        {
            if (letter != null)
            {
                EmployeeLetter dbLetter = _mapper.Map<EmployeeLetter>(letter);
                dbLetter.Date = DateTime.Now;
                _letterRepository.AddLetter(dbLetter);
                return true;
            }
            return false;
        }
    }
}
