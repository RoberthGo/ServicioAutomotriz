using System;
using System.Collections.Generic;
using System.Data.Common;
using AutoRepair.Data.Repositories;

namespace AutoRepair.Data.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        public IEnumerable<Service> GetAll()
        {
            var list = new List<Service>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Description, Price FROM Services";
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new Service
                            {
                                Id = rdr.GetInt32(0),
                                Description = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                                Price = rdr.GetDecimal(2)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public Service GetById(int id)
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Description, Price FROM Services WHERE Id = @id";
                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = id; cmd.Parameters.Add(p);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return new Service
                            {
                                Id = rdr.GetInt32(0),
                                Description = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                                Price = rdr.GetDecimal(2)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Add(Service entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Services (Description, Price) VALUES (@desc, @price);";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@desc"; p1.Value = (object)entity.Description ?? DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@price"; p2.Value = entity.Price; cmd.Parameters.Add(p2);
                    cmd.ExecuteNonQuery();
                    // Retrieve last inserted id (MySQL)
                    cmd.CommandText = "SELECT LAST_INSERT_ID();";
                    cmd.Parameters.Clear();
                    var idObj = cmd.ExecuteScalar();
                    if (idObj != null && int.TryParse(idObj.ToString(), out int id))
                    {
                        entity.Id = id;
                    }
                }
            }
        }

        public void Update(Service entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Services SET Description = @desc, Price = @price WHERE Id = @id";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@desc"; p1.Value = (object)entity.Description ?? DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@price"; p2.Value = entity.Price; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@id"; p3.Value = entity.Id; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Service entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Services WHERE Id = @id";
                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = entity.Id; cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveChanges()
        {
            // no-op: operations are executed immediately
        }
    }
}
