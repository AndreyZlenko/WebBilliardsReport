using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class TableStatisticsRepository : IRepository<TableStatistics>
    {

        private HallContextEntity db;

        public TableStatisticsRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(TableStatistics item)
        {
            db.TableStatistics.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            TableStatistics tableStatistics = db.TableStatistics.Find(id);
            if (tableStatistics != null)
            {
                db.TableStatistics.Remove(tableStatistics);
                db.SaveChanges();
            }
        }

        public List<TableStatistics> Find(Func<TableStatistics, bool> predicate)
        {
            return db.TableStatistics.Where(predicate).ToList();
        }

        public TableStatistics Get(int id)
        {
            return db.TableStatistics.Find(id);
        }

        public List<TableStatistics> GetAll()
        {
            return db.TableStatistics.ToList();
        }

        public void Update(TableStatistics item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
