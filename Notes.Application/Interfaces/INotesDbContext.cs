using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.Application.Interfaces
{
    public interface INotesDbContext
    {

        // Представляет коллекцию всех сущностей в контексте или может запрашиваться из БД заданного типа
        DbSet<Note> Notes { get; set; }

        // Дублируем сигнатуру ради удобства из DbContext EntityFramework-а
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
 