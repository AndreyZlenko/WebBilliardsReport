using System;
using System.Linq;
using System.Collections.Generic;
using BilliardsReport.Domain.Context;
using BilliardsReport.Domain.Interfaces;
using BilliardsReport.Domain.Models;

namespace BilliardsReport.Domain.Repositories
{
    public class TableCategoryRepository : IRepository<TableCategory>
    {

        private HallContextEntity db;

        public TableCategoryRepository(HallContextEntity database)
        {
            this.db = database;
            this.db.Database.Initialize(false);
        }

        public void Create(TableCategory item)
        {
            db.TableCategories.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            TableCategory tableCategory = db.TableCategories.Find(id);
            if (tableCategory != null)
            {
                db.TableCategories.Remove(tableCategory);
                db.SaveChanges();
            }
        }

        public List<TableCategory> Find(Func<TableCategory, bool> predicate)
        {
            return db.TableCategories.Where(predicate).ToList();
        }

        public TableCategory Get(int id)
        {
            return db.TableCategories.Find(id);
        }

        public List<TableCategory> GetAll()
        {
            return db.TableCategories.ToList();
        }

        public void Update(TableCategory item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
