using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProjects_Inheritance
{
    public class ClassTeacher : Teacher
    {
        private CClass whichClass;

        public CClass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }

}
