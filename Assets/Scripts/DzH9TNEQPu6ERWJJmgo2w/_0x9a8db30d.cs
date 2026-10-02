using UnityEngine;

// Night-haul palette. One TMP material serves the whole app and its outline is dark
// (Ink), so every colour used as a TEXT FACE here is light: a dark face would be
// swallowed by its own outline (rule C.14). Ink / Night / Panel are surface colours
// only - they never reach a label.
public static class _0x9a8db30d
{
    public static readonly Color GoldDeep = new Color(0.5412f, 0.4157f, 0.0784f, 1f);
    public static readonly Color PanelLit = new Color(0.149f, 0.1686f, 0.2196f, 1f);
    public static readonly Color Steel = new Color(0.2275f, 0.2314f, 0.2588f, 1f);
    public static readonly Color Teal = new Color(0.2157f, 0.7216f, 0.8f, 1f);
    public static readonly Color Ink = new Color(0.0549f, 0.0627f, 0.0863f, 1f);
    public static readonly Color Night = new Color(0.0902f, 0.102f, 0.1333f, 1f);
    // Crate colours, indexed the same way everywhere: 0 gold, 1 red, 2 teal, 3 green.
    // They differ in LUMINANCE as well as hue, so the order stays readable without
    // relying on colour vision alone.
    public static Color Crate(int _0xbc01f32a)
    {
        if (_0xbc01f32a == 1)
            return Red;
        if (_0xbc01f32a == 2)
            return Teal;
        if (_0xbc01f32a == 3)
            return Green;
        return Gold;
    }

    public static readonly Color Cream = new Color(1f, 0.9451f, 0.8392f, 1f);
    public static readonly Color Green = new Color(0.4784f, 0.7843f, 0.3098f, 1f);
    public static readonly Color Panel = new Color(0.1176f, 0.1333f, 0.1725f, 1f);
    public static readonly Color Gold = new Color(0.9608f, 0.7686f, 0.2588f, 1f);
    public static readonly Color Red = new Color(0.9137f, 0.2941f, 0.2392f, 1f);
    public static Color Alpha(Color _0x3ac2e5ea, float _0x356db354)
    {
        return new Color(_0x3ac2e5ea.r, _0x3ac2e5ea.g, _0x3ac2e5ea.b, _0x356db354);
    }

    public static readonly Color Sand = new Color(0.6588f, 0.6118f, 0.5176f, 1f);
}