using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class TableRepository : IRepository<Table>
    {

        private HallContextEntity db;

        public TableRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(Table item)
        {
            db.Tables.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Table table = db.Tables.Find(id);
            if (table != null)
            {
                db.Tables.Remove(table);
                db.SaveChanges();
            }
        }

        public List<Table> Find(Func<Table, bool> predicate)
        {
            return db.Tables.Where(predicate).ToList();
        }

        public Table Get(int id)
        {
            return db.Tables.Find(id);
        }

        public List<Table> GetAll()
        {
            return db.Tables.ToList();
        }

        public void Update(Table item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
