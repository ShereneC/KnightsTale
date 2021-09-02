using System;
using System.Collections.Generic;
using KnightsTale.Models;
using KnightsTale.Repositories;

namespace KnightsTale.Services
{
  public class CastlesService
  {

      private readonly CastlesRepository _repo;

      public CastlesService(CastlesRepository repo)
      {
          _repo = repo;
      }
    internal IEnumerable<Castle> GetAllCastles()
    {
      return _repo.GetAllCastles();
    }

    internal Castle GetCastleById(int id)
    {
      Castle castle = _repo.GetCastleById(id);
      if (castle == null)
      {
        throw new Exception("Invalid Id");
      }
      return castle;
    }

    internal Castle Create(Castle newCastle)
    {
      Castle castle = _repo.Create(newCastle);
      if (castle == null)
      {
          throw new Exception("Invalid Id");
      }
      return castle;
    }

    internal void DeleteCastle(int id)
    {
      Castle original = Get(id);
      _repo.Delete(id);
    }
  }
}