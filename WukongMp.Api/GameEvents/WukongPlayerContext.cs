using ReadyM.Api.ECS.Worlds;
using WukongMp.Api.State;

namespace WukongMp.Api.GameEvents;

/// <summary>
/// The game event context for WukongMP's own policies: the local player, the current area and the world. Read by
/// <see cref="ECS.GameEvents.SpawnSummonEvent"/>'s hand-written policy.
/// </summary>
internal readonly struct WukongPlayerContext(WukongPlayerState playerState, WukongAreaState areaState, Store world)
{
    public readonly WukongPlayerState PlayerState = playerState;
    public readonly WukongAreaState AreaState = areaState;
    public readonly Store World = world;
}
