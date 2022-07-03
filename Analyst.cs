using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_slip
{
    class Analyst:Employee
    {
        private
            int f_allounce = 150;
            int m_allounce = 800;
        public int Salary_slip()
        {
            return f_allounce + m_allounce + Basic_Sallery;
        }
    }
}
