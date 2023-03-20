//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity sourcesComponentsGameSpawnPointComponenctEntity { get { return GetGroup(GameMatcher.SourcesComponentsGameSpawnPointComponenct).GetSingleEntity(); } }
    public Sources.Components.Game.SpawnPointComponenct sourcesComponentsGameSpawnPointComponenct { get { return sourcesComponentsGameSpawnPointComponenctEntity.sourcesComponentsGameSpawnPointComponenct; } }
    public bool hasSourcesComponentsGameSpawnPointComponenct { get { return sourcesComponentsGameSpawnPointComponenctEntity != null; } }

    public GameEntity SetSourcesComponentsGameSpawnPointComponenct(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation) {
        if (hasSourcesComponentsGameSpawnPointComponenct) {
            throw new Entitas.EntitasException("Could not set SourcesComponentsGameSpawnPointComponenct!\n" + this + " already has an entity with Sources.Components.Game.SpawnPointComponenct!",
                "You should check if the context already has a sourcesComponentsGameSpawnPointComponenctEntity before setting it or use context.ReplaceSourcesComponentsGameSpawnPointComponenct().");
        }
        var entity = CreateEntity();
        entity.AddSourcesComponentsGameSpawnPointComponenct(newPosition, newRotation);
        return entity;
    }

    public void ReplaceSourcesComponentsGameSpawnPointComponenct(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation) {
        var entity = sourcesComponentsGameSpawnPointComponenctEntity;
        if (entity == null) {
            entity = SetSourcesComponentsGameSpawnPointComponenct(newPosition, newRotation);
        } else {
            entity.ReplaceSourcesComponentsGameSpawnPointComponenct(newPosition, newRotation);
        }
    }

    public void RemoveSourcesComponentsGameSpawnPointComponenct() {
        sourcesComponentsGameSpawnPointComponenctEntity.Destroy();
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
public partial class GameEntity {

    public Sources.Components.Game.SpawnPointComponenct sourcesComponentsGameSpawnPointComponenct { get { return (Sources.Components.Game.SpawnPointComponenct)GetComponent(GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct); } }
    public bool hasSourcesComponentsGameSpawnPointComponenct { get { return HasComponent(GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct); } }

    public void AddSourcesComponentsGameSpawnPointComponenct(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation) {
        var index = GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct;
        var component = (Sources.Components.Game.SpawnPointComponenct)CreateComponent(index, typeof(Sources.Components.Game.SpawnPointComponenct));
        component.position = newPosition;
        component.rotation = newRotation;
        AddComponent(index, component);
    }

    public void ReplaceSourcesComponentsGameSpawnPointComponenct(UnityEngine.Vector3 newPosition, UnityEngine.Quaternion newRotation) {
        var index = GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct;
        var component = (Sources.Components.Game.SpawnPointComponenct)CreateComponent(index, typeof(Sources.Components.Game.SpawnPointComponenct));
        component.position = newPosition;
        component.rotation = newRotation;
        ReplaceComponent(index, component);
    }

    public void RemoveSourcesComponentsGameSpawnPointComponenct() {
        RemoveComponent(GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSourcesComponentsGameSpawnPointComponenct;

    public static Entitas.IMatcher<GameEntity> SourcesComponentsGameSpawnPointComponenct {
        get {
            if (_matcherSourcesComponentsGameSpawnPointComponenct == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SourcesComponentsGameSpawnPointComponenct);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSourcesComponentsGameSpawnPointComponenct = matcher;
            }

            return _matcherSourcesComponentsGameSpawnPointComponenct;
        }
    }
}
