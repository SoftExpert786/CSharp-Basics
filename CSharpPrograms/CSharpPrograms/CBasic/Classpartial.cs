using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.CBasic
{
    public partial class ClassPartial
    {
        private string _F_Name;
        private string _S_Name;
        public string fIrstName
        {
            get { return _F_Name; }
            set { _F_Name = value; }
        }

        public string S_Name { get => _S_Name; set => _S_Name = value; }
    }
}
