using ArquiteturaSW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaSW.DAL.Interfaces
{
    interface IMovelDAL
    {
        List<Movel> BuscarMoveis();

        Movel BuscarMovel(int id);


    }
}
