using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Data;

namespace GestionProduit.Infrastuctures
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private GPContext dataContext;
        public GPContext DataContext
        {
            get { return dataContext; }
        }
        public DatabaseFactory()
        {
            dataContext = new GPContext();
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}