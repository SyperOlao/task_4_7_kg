using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
     /**
      * Описывает трехмерную модель в общем виде  
      */
    interface IModel
    {
        List<PolyLines3D> GetLines(); 

    }
}
