using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence
{
    /// <summary>
    /// Нужен для проверки создания БД  
    /// </summary>
    public class DbInitializer
    {
        /// <summary>
        /// Проверяет и инициализирует БД, если ее не существует
        /// </summary>
        /// <param name="context"></param>
        public static void Initialize(NotesDbContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
