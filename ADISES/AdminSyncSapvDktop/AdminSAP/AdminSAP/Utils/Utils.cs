using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSAP.Utils
{
    public class Utils
    {
        public Color colorPrimary = Color.FromArgb(255, 255, 255);
        public Color BackColorToolBar = Color.FromArgb(55, 51, 52);
        public Color backColorForm = Color.White;
        public static Utils getInstance() => new Utils();

        public static string parseStringBD(string column)
        {
            return $"\"{column}\"";
        }

        
    }
}
