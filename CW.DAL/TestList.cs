using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.DAL
{
    public class TestList
    {
        public List<Test> GetAllTests()
        {
            return new TestManager().GetAll();
        }
    }
}
