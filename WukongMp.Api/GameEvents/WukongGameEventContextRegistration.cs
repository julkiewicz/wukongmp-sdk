using ReadyM.Api.ECS.Worlds;
using ReadyM.Api.Mapping.Events;
using WukongMp.Api.State;

namespace WukongMp.Api.GameEvents;

/// <summary>Registers WukongMP's game event context, next to the client's ownership and master-client ones.</summary>
internal sealed class WukongGameEventContextRegistration(
    WukongPlayerState playerState,
    WukongAreaState areaState,
    Store world
) : IGameEventContextRegistration
{
    public void Register(GameEventContextRegistry registry)
        => registry.Register(new WukongPlayerContext(playerState, areaState, world));
}
