using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace API_Test
{
   // internal class ListOfUsersDataTransfer
    //{


    public partial class ListOfUsersDataTransfer //Welcome
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Data Data { get; set; }
    }

    public partial class Data
    {
        public virtual string DataColor { get; set; }
        public virtual string DataCapacity { get; set; }
        public virtual long? CapacityGb { get; set; }
        public virtual double? DataPrice { get; set; }
        public virtual string DataGeneration { get; set; }
        public virtual long? Year { get; set; }
        public virtual string CpuModel { get; set; }
        public virtual string HardDiskSize { get; set; }
        public virtual string StrapColour { get; set; }
        public virtual string CaseSize { get; set; }
        public virtual string Color { get; set; }
        public virtual string Description { get; set; }
        public virtual string Capacity { get; set; }
        public virtual double? ScreenSize { get; set; }
        public virtual string Generation { get; set; }
        public virtual string Price { get; set; }
    }
}

    

