using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    class MyForms
    {
        public static T GetForm<T>() where T : class, new()
        {
            return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
        }
    }
}
