using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Test
{
    public class CreateUserDataTransfer
    {        
           public virtual long Id { get; set; }
            public virtual string Name { get; set; }
            public virtual Data Data { get; set; }
            public virtual DateTimeOffset CreatedAt { get; set; }
    }

        public partial class Data
        {
            //public virtual long Year { get; set; }
          //  public virtual double Price { get; set; }
           // public virtual string CpuModel { get; set; }
           // public virtual string HardDiskSize { get; set; }
        }

}

