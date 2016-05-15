using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class GameHallRepository : IRepository<GameHall>
    {

        private HallContextEntity db;

        public GameHallRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(GameHall item)
        {
            db.GameHalls.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            GameHall gameHall = db.GameHalls.Find(id);
            if (gameHall != null)
            {
                db.GameHalls.Remove(gameHall);
                db.SaveChanges();
            }
        }

        public List<GameHall> Find(Func<GameHall, bool> predicate)
        {
            return db.GameHalls.Where(predicate).ToList();
        }

        public GameHall Get(int id)
        {
            return db.GameHalls.Find(id);
        }

        public List<GameHall> GetAll()
        {
            return db.GameHalls.ToList();
        }

        public void Update(GameHall item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
