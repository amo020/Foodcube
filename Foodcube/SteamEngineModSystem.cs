//using Vintagestory.API.Client;
using Vintagestory.API.Common;
//using Vintagestory.API.Config;
//using Vintagestory.API.Server;

namespace SteamEngine
{
    public class SteamEngineModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            // Register Block Classes
            api.RegisterBlockClass("BlockSteam", typeof(BlockSteam));

            // Register Block Entities
            api.RegisterBlockEntityClass("BEFirebox", typeof(BlockEntityFirebox));
            api.RegisterBlockEntityClass("BEBoiler", typeof(BlockEntityBoiler));
            api.RegisterBlockEntityClass("BEPressurePipe", typeof(BlockEntityPressurePipe));
            api.RegisterBlockEntityClass("BESteamEngine", typeof(BlockEntitySteamEngine));

            // Register Mechanical Power Behavior
            api.RegisterBlockEntityBehaviorClass("SteamEnginePower", typeof(BEBehaviorSteamEngine));
        }
    }
}