using System.Runtime.InteropServices;

namespace PG3D_External.Sys.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int Left, Top, Right, Bottom;
    }
}