using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class DiscountCardRepository : IRepository<DiscountCard>
    {

        private HallContextEntity db;

        public DiscountCardRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(DiscountCard item)
        {
            db.DiscountCards.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            DiscountCard discountCard = db.DiscountCards.Find(id);
            if (discountCard != null)
            {
                db.DiscountCards.Remove(discountCard);
                db.SaveChanges();
            }
        }

        public List<DiscountCard> Find(Func<DiscountCard, bool> predicate)
        {
            return db.DiscountCards.Where(predicate).ToList();
        }

        public DiscountCard Get(int id)
        {
            return db.DiscountCards.Find(id);
        }

        public List<DiscountCard> GetAll()
        {
            return db.DiscountCards.ToList();
        }

        public void Update(DiscountCard item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
