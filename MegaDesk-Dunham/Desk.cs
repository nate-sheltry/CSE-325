using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Dunham
{
    public class Desk
    {
        public static int MAXWIDTH = 96;
        public static int MINWIDTH = 24;

        public static int MAXDEPTH = 48;
        public static int MINDEPTH = 12;

    }

    public enum DesktopMaterialType
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }

    public class DesktopMaterial
    {
        public DesktopMaterialType MaterialType { get; set; }

        public DesktopMaterial(DesktopMaterialType materialType)
        {
            MaterialType = materialType;
        }

        public override string ToString()
        {
            return MaterialType.ToString();
            {

            }
        }
    }
}
