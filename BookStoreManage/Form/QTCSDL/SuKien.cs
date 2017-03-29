using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTCSDL
{
    public class SuKien
    {
        private string so;
        public string So
        {
            get { return so; }
            set { so = value; }
        }

        public SuKien(string so)
        {
            this.So = so;
        }
    }
}
