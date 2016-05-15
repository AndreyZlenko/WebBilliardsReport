using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class HallOwnerRepository : IRepository<HallOwner>
    {

        private HallContextEntity db;

        public HallOwnerRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(HallOwner item)
        {
            db.HallOwners.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            HallOwner hallOwner = db.HallOwners.Find(id);
            if (hallOwner != null)
            {
                db.HallOwners.Remove(hallOwner);
                db.SaveChanges();
            }
        }

        public List<HallOwner> Find(Func<HallOwner, bool> predicate)
        {
            return db.HallOwners.Where(predicate).ToList();
        }

        public HallOwner Get(int id)
        {
            return db.HallOwners.Find(id);
        }

        public List<HallOwner> GetAll()
        {
            return db.HallOwners.ToList();
        }

        public void Update(HallOwner item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
