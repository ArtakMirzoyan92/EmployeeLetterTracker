using AutoMapper;
using BusinessLayer.Models;
using DataAccessLayer.Entities;

namespace BusinessLayer.Profiles
{
    public class LetterProfile : Profile
    {
        public LetterProfile()
        {
            CreateMap<LetterForCreate, EmployeeLetter>();
        }
    }
}
