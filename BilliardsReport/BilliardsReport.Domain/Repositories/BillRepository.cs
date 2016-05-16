using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class BillRepository : IRepository<Bill>
    {
        private HallContextEntity db;

        public BillRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(Bill item)
        {
            db.Bills.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Bill bill = db.Bills.Find(id);
            if (bill != null)
            {
                db.Bills.Remove(bill);
                db.SaveChanges();
            }
        }

        public List<Bill> Find(Func<Bill, bool> predicate)
        {
            return db.Bills.Where(predicate).ToList();
        }

        public Bill Get(int id)
        {
            return db.Bills.Find(id);
        }

        public List<Bill> GetAll()
        {
            return db.Bills.ToList();
        }

        public void Update(Bill item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
