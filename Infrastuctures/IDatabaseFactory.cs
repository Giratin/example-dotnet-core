using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Data;

namespace GestionProduit.Infrastuctures
{
    public interface IDatabaseFactory : IDisposable
    {
        GPContext DataContext { get; }
    }
}