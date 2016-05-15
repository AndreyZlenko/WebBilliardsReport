using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class HallStatisticsRepository : IRepository<HallStatistics>
    {

        private HallContextEntity db;

        public HallStatisticsRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(HallStatistics item)
        {
            db.HallStatistics.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            HallStatistics hallStatistics = db.HallStatistics.Find(id);
            if (hallStatistics != null)
            {
                db.HallStatistics.Remove(hallStatistics);
                db.SaveChanges();
            }
        }

        public List<HallStatistics> Find(Func<HallStatistics, bool> predicate)
        {
            return db.HallStatistics.Where(predicate).ToList();
        }

        public HallStatistics Get(int id)
        {
            return db.HallStatistics.Find(id);
        }

        public List<HallStatistics> GetAll()
        {
            return db.HallStatistics.ToList();
        }

        public void Update(HallStatistics item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
