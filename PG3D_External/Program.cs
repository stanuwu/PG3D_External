using PG3D_External;

Console.WriteLine("Cheating :3");
Console.WriteLine("github.com/stanuwu & github.com/hiderikzki");

PixelGunCheat Cheat = new PixelGunCheat();
Task.Run(Cheat.OnStartup);

AppDomain.CurrentDomain.ProcessExit += (sender, eventArgs) =>
{
    Console.WriteLine("Closing...");
    Cheat.Dispose();
};