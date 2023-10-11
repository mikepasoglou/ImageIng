using System.Drawing;

namespace ImageIng.Client
{
    public static class GlobalVariables
    {

        public static byte[] GLuserimgBytearray { get; set; }
        public static byte[] GLtempimgBytearray { get; set; }
        public static Bitmap? InitialBitmap { get; set; } = null;
    }
}
