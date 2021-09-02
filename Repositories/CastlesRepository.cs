using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using KnightsTale.Models;

namespace KnightsTale.Repositories
{
  public class CastlesRepository
  {

      private readonly IDbConnection _db;

      public CastlesRepository(IDbConnection db)
      {
          _db = db;
      }
    internal IEnumerable<Castle> GetAllCastles()
    {
      string sql = "SELECT * FROM castles";
      return _db.Query<Castle>(sql).ToList();
    }

    internal Castle GetCastleById(int id)
    {
      string sql = "SELECT * FROM castles WHERE id = @id";
      return _db.QueryFirstOrDefault<Castle>(sql, new { id });
    }

    internal Castle Create(Castle newCastle)
    {
      string sql = @"
      INSERT INTO castles
      (name, location, picture)
      VALUES
      (@Name, @Location, @Picture);
      SELECT LAST_INSERT_ID();";
      newCastle.Id = _db.ExecuteScalar<int>(sql, newCastle);
      return newCastle;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM castles WHERE id = @id LIMIT 1";
      _db.Execute(sql, new { id });
    }
  }
}