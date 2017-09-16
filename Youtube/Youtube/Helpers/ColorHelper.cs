using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Helpers
{
    public static class ColorHelper
    {
        public static string ToHexString(this Color c) => $"#{ColorAsInt(c.A):x2}{ColorAsInt(c.R):x2}{ColorAsInt(c.G):x2}{ColorAsInt(c.B):x2}";

        private static int ColorAsInt(double color) => (int)(color * 255);
    }
}
