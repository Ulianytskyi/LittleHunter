//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class NetworkContext {

    public NetworkEntity sourcesComponentsNetworkLauncherShouldConnectEntity { get { return GetGroup(NetworkMatcher.SourcesComponentsNetworkLauncherShouldConnect).GetSingleEntity(); } }

    public bool isSourcesComponentsNetworkLauncherShouldConnect {
        get { return sourcesComponentsNetworkLauncherShouldConnectEntity != null; }
        set {
            var entity = sourcesComponentsNetworkLauncherShouldConnectEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isSourcesComponentsNetworkLauncherShouldConnect = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class NetworkEntity {

    static readonly Sources.Components.Network.Launcher.ShouldConnectComponent sourcesComponentsNetworkLauncherShouldConnectComponent = new Sources.Components.Network.Launcher.ShouldConnectComponent();

    public bool isSourcesComponentsNetworkLauncherShouldConnect {
        get { return HasComponent(NetworkComponentsLookup.SourcesComponentsNetworkLauncherShouldConnect); }
        set {
            if (value != isSourcesComponentsNetworkLauncherShouldConnect) {
                var index = NetworkComponentsLookup.SourcesComponentsNetworkLauncherShouldConnect;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sourcesComponentsNetworkLauncherShouldConnectComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class NetworkMatcher {

    static Entitas.IMatcher<NetworkEntity> _matcherSourcesComponentsNetworkLauncherShouldConnect;

    public static Entitas.IMatcher<NetworkEntity> SourcesComponentsNetworkLauncherShouldConnect {
        get {
            if (_matcherSourcesComponentsNetworkLauncherShouldConnect == null) {
                var matcher = (Entitas.Matcher<NetworkEntity>)Entitas.Matcher<NetworkEntity>.AllOf(NetworkComponentsLookup.SourcesComponentsNetworkLauncherShouldConnect);
                matcher.componentNames = NetworkComponentsLookup.componentNames;
                _matcherSourcesComponentsNetworkLauncherShouldConnect = matcher;
            }

            return _matcherSourcesComponentsNetworkLauncherShouldConnect;
        }
    }
}
