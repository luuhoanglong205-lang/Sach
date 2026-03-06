using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class LietKeSo
    {
        public List<int> LietKe()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
