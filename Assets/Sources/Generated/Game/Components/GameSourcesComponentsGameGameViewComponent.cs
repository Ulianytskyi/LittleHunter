//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Sources.Components.Game.GameViewComponent sourcesComponentsGameGameView { get { return (Sources.Components.Game.GameViewComponent)GetComponent(GameComponentsLookup.SourcesComponentsGameGameView); } }
    public bool hasSourcesComponentsGameGameView { get { return HasComponent(GameComponentsLookup.SourcesComponentsGameGameView); } }

    public void AddSourcesComponentsGameGameView(UnityEngine.GameObject newGameObject, UnityEngine.Transform newTransform) {
        var index = GameComponentsLookup.SourcesComponentsGameGameView;
        var component = (Sources.Components.Game.GameViewComponent)CreateComponent(index, typeof(Sources.Components.Game.GameViewComponent));
        component.gameObject = newGameObject;
        component.transform = newTransform;
        AddComponent(index, component);
    }

    public void ReplaceSourcesComponentsGameGameView(UnityEngine.GameObject newGameObject, UnityEngine.Transform newTransform) {
        var index = GameComponentsLookup.SourcesComponentsGameGameView;
        var component = (Sources.Components.Game.GameViewComponent)CreateComponent(index, typeof(Sources.Components.Game.GameViewComponent));
        component.gameObject = newGameObject;
        component.transform = newTransform;
        ReplaceComponent(index, component);
    }

    public void RemoveSourcesComponentsGameGameView() {
        RemoveComponent(GameComponentsLookup.SourcesComponentsGameGameView);
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

    static Entitas.IMatcher<GameEntity> _matcherSourcesComponentsGameGameView;

    public static Entitas.IMatcher<GameEntity> SourcesComponentsGameGameView {
        get {
            if (_matcherSourcesComponentsGameGameView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SourcesComponentsGameGameView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSourcesComponentsGameGameView = matcher;
            }

            return _matcherSourcesComponentsGameGameView;
        }
    }
}
