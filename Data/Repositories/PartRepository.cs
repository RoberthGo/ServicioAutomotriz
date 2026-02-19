using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using AutoRepair.Data.Repositories;

namespace AutoRepair.Data.Repositories
{
    public class PartRepository : IRepository<Part>
    {
        public IEnumerable<Part> GetAll()
        {
            var list = new List<Part>();
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name, Stock, Price FROM Parts";
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new Part
                            {
                                Id = rdr.GetInt32(0),
                                Name = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                                Stock = rdr.GetInt32(2),
                                Price = rdr.GetDecimal(3)
                            });
                        }
                    }
                }
            }
            return list;
        }

        public Part GetById(int id)
        {
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name, Stock, Price FROM Parts WHERE Id = @id";
                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = id; cmd.Parameters.Add(p);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return new Part
                            {
                                Id = rdr.GetInt32(0),
                                Name = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                                Stock = rdr.GetInt32(2),
                                Price = rdr.GetDecimal(3)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void Add(Part entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Parts (Name, Stock, Price) VALUES (@name, @stock, @price);";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@name"; p1.Value = (object)entity.Name ?? DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@stock"; p2.Value = entity.Stock; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@price"; p3.Value = entity.Price; cmd.Parameters.Add(p3);
                    cmd.ExecuteNonQuery();
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

        public void Update(Part entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Parts SET Name = @name, Stock = @stock, Price = @price WHERE Id = @id";
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@name"; p1.Value = (object)entity.Name ?? DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@stock"; p2.Value = entity.Stock; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@price"; p3.Value = entity.Price; cmd.Parameters.Add(p3);
                    var p4 = cmd.CreateParameter(); p4.ParameterName = "@id"; p4.Value = entity.Id; cmd.Parameters.Add(p4);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Part entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            using (var conn = Database.CreateConnection())
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Parts WHERE Id = @id";
                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = entity.Id; cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveChanges()
        {
            // no-op: operations executed immediately
        }
    }
}
