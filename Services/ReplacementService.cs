using ServicioAutomotriz.Data;
using ServicioAutomotriz.Models;

namespace ServicioAutomotriz.Services
{
    public class ReplacementService
    {
        // Retorna todas las refacciones ordenadas por nombre
        public List<Replacement> GetAll()
        {
            using var db = new AppDbContext();
            return db.Replacements.OrderBy(r => r.Name).ToList();
        }

        // Agrega una nueva refacción a la base de datos
        public void Add(Replacement replacement)
        {
            using var db = new AppDbContext();
            db.Replacements.Add(replacement);
            db.SaveChanges();
        }

        // Actualiza los datos de una refacción existente
        public void Update(Replacement replacement)
        {
            using var db = new AppDbContext();
            db.Replacements.Update(replacement);
            db.SaveChanges();
        }

        // Elimina la refacción solo si existe
        public void Delete(int id)
        {
            using var db = new AppDbContext();
            var item = db.Replacements.Find(id);
            if (item is not null)
            {
                db.Replacements.Remove(item);
                db.SaveChanges();
            }
        }
    }
}
