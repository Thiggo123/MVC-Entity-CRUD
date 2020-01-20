using MVC_Treinando.Data;
using MVC_Treinando.Models;
using MVC_Treinando.repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Treinando.UnitofWork
{
    public class UnitofWork : DbContext
    {

        ContextApp context = new ContextApp();
        Repository<Products> productRepository;



        public Repository<Products> ProductRepository
        {

            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Products>(context);

                }
                return productRepository;
            }


        }

        public void Commit()
        {
            context.SaveChanges();
        }
            




            
        }

    }
