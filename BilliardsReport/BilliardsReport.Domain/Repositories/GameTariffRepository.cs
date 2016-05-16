using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class GameTariffRepository : IRepository<GameTariff>
    {

        private HallContextEntity db;

        public GameTariffRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(GameTariff item)
        {
            db.GameTariffs.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            GameTariff gameTariff = db.GameTariffs.Find(id);
            if (gameTariff != null)
            {
                db.GameTariffs.Remove(gameTariff);
                db.SaveChanges();
            }
        }

        public List<GameTariff> Find(Func<GameTariff, bool> predicate)
        {
            return db.GameTariffs.Where(predicate).ToList();
        }

        public GameTariff Get(int id)
        {
            return db.GameTariffs.Find(id);
        }

        public List<GameTariff> GetAll()
        {
            return db.GameTariffs.ToList();
        }

        public void Update(GameTariff item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
