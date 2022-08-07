using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Pacagroup.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        //  //Vamos a crear un metodo que nos permite interactuar con nuestro Gestor de base
        //  //  de datos.
        IDbConnection GetConnection { get; }

    }
}
