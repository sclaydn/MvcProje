﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName== "" || p.CategoryName.Length <=3 || p.CategoryDescription=="" || p.CategoryName.Length >=51)
            {
                //hata mesaji
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
