using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_slip
{
    internal class Engineer:Employee
    {
        private
            int f_allounce = 100;
            int m_allounce = 500;
        public int Salary_slip()
        {
            return f_allounce + m_allounce + Basic_Sallery;
        }
    }
}
