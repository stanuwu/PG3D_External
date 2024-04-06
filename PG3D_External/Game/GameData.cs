using PG3D_External.Utils;

namespace PG3D_External.Game
{
    public class GameData : TickThread
    {
        public GameData(GameProcess gameProcess) : base(nameof(GameData))
        {
            GameProcess = gameProcess;
        }
        
        public GameProcess GameProcess { get; private set; }
        
        public override void Dispose()
        {
            base.Dispose();
            
            GameProcess = default;
        }

        protected override void Tick()
        {
            if (!GameProcess.IsValid) return;
            
            
        }
    }
}