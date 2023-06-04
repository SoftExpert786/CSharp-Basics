using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    [Serializable]
    internal class SerializationConcept
    {
        public int Id;
        public string Name;
        public SerializationConcept(int Id,String Name)
        {this.Id = Id;
            this.Name = Name;
                
        }
    }
}
