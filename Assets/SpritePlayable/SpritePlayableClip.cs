using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SpritePlayableClip : PlayableAsset, ITimelineClipAsset
{
    public SpritePlayableBehaviour template = new SpritePlayableBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<SpritePlayableBehaviour>.Create (graph, template);
        return playable;
    }
}
