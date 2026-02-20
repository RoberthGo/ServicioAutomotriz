using ServicioAutomotriz.Data;
using ServicioAutomotriz.Models;

namespace ServicioAutomotriz.Services
{
    public class ServiceService
    {
        // Retorna todos los servicios ordenados por nombre
        public List<Service> GetAll()
        {
            using var db = new AppDbContext();
            return db.Services.OrderBy(s => s.Name).ToList();
        }

        // Agrega un nuevo servicio a la base de datos
        public void Add(Service service)
        {
            using var db = new AppDbContext();
            db.Services.Add(service);
            db.SaveChanges();
        }

        // Actualiza los datos de un servicio existente
        public void Update(Service service)
        {
            using var db = new AppDbContext();
            db.Services.Update(service);
            db.SaveChanges();
        }

        // Elimina el servicio solo si existe
        public void Delete(int id)
        {
            using var db = new AppDbContext();
            var item = db.Services.Find(id);
            if (item is not null)
            {
                db.Services.Remove(item);
                db.SaveChanges();
            }
        }
    }
}
