using BusinessLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface ILetterService
    {
        bool Add(LetterForCreate letter);
    }
}
