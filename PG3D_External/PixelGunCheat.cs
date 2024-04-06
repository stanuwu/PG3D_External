using System.Diagnostics;

namespace PG3D_External
{
    public class PixelGunCheat : IDisposable
    {
        public const int Version = 2;


        public void Dispose()
        {
            // Dispose All Components
        }

        public void OnStartup()
        {
            // set process priority
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            
        }
    }
}