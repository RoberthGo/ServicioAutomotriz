using ServicioAutomotriz.Data;
using ServicioAutomotriz.Models;

namespace ServicioAutomotriz.Services
{
    public class ServiceService
    {
        public List<Service> GetAll()
        {
            using var db = new AppDbContext();
            return db.Services.OrderBy(s => s.Name).ToList();
        }

        public void Add(Service service)
        {
            using var db = new AppDbContext();
            db.Services.Add(service);
            db.SaveChanges();
        }

        public void Update(Service service)
        {
            using var db = new AppDbContext();
            db.Services.Update(service);
            db.SaveChanges();
        }

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
