using Entitas;

namespace Sources.Components.Game
{
    /// <summary>
    /// Stores the PhotoView associated with the entity. 
    /// </summary>
    [Game]
    public sealed class PhotonViewComponent : IComponent
    {
        public Photon.Pun.PhotonView value;
    }
}
