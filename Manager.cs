using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_slip
{
    class Manager:Employee
    {
        private
            int f_allounce = 250;
            int m_allounce = 1000;
        public int Salary_slip()
        {
            return Basic_Sallery + f_allounce + m_allounce;
        }
    }
}
