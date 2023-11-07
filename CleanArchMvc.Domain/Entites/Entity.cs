using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entites
{
    public abstract class Entity
    {
        public int Id { get; protected set; }

        //mais exemplos de propriedade para Entity
        //    public DateTime CreatedDate { get; protected set; }
        //    public DateTime ModifiedDate { get; protected set;  } 

        //    public string CreatedBy { get; protected set; }
        //    public string ModifiedBy { get; protected set; }
        //}
    }
}
