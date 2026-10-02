using TMPro;
using UnityEngine;

// Every label in this game is made here, so the rules that a static checker cannot see
// hold everywhere at once (rule C.10):
//   * word wrap OFF - line breaks are explicit "\n" in the string;
//   * autosize ALWAYS on, with the minimum parked on the readability floor (24);
//   * a per-label material instance whose outline contrasts with the face colour.
public static class _0x9ed53401
{
    // Rewrites a template label in place and re-applies the same discipline, used for
    // the panels this game inherits but does not author (tutorial bodies, pop rows).
    public static void Dress(TMP_Text _0x59b5043b, string _0x6b7ca53f, float _0x98169c01, Color _0xa2d0d084)
    {
        if (_0x59b5043b == null)
            return;
        _0x59b5043b.text = _0x6b7ca53f;
        _0x59b5043b.color = _0xa2d0d084;
        _0x59b5043b.enableWordWrapping = false;
        _0x59b5043b.overflowMode = TextOverflowModes.Overflow;
        _0x59b5043b.enableAutoSizing = true;
        _0x59b5043b.fontSizeMin = 24f;
        _0x59b5043b.fontSizeMax = Mathf.Max(24f, _0x98169c01);
        ApplyOutline(_0x59b5043b, _0xa2d0d084);
    }

    // Readability floor for UGUI text on a 1080x2400 screen (rule C.12). Autosize
    // shrinks a long line down to this, so it is the size that actually ships.
    public const float MinSize = 24f;
    public static string Pair(string _0xccbdf939, int _0x4b3dd37a, int _0x700cc0e6)
    {
        return _0xccbdf939 + _0x0ae1c51f._0x450ecd75(new byte[1] { 130 }, 162) + _0x4b3dd37a.ToString(_0x0ae1c51f._0x450ecd75(new byte[2] { 40, 40 }, 24)) + _0x0ae1c51f._0x450ecd75(new byte[3] { 194, 205, 194 }, 226) + _0x700cc0e6.ToString(_0x0ae1c51f._0x450ecd75(new byte[2] { 219, 219 }, 235));
    }

    // The font asset is handed in rather than left to TMP's own lazy load: a label
    // created under a SWITCHED-OFF parent (every pop body is) never runs Awake, so its
    // shared material would still be null when the outline is applied below.
    public static TextMeshProUGUI Label(Transform _0x865cd978, TMP_FontAsset _0x78618b30, string _0xd6c69d54, Vector2 _0x17f89d2b, Vector2 _0xcfa019e3, Vector2 _0xbed7c7e7, float _0x37172423, Color _0xba504893, TextAlignmentOptions _0xf4d2ae8f)
    {
        GameObject _0x23559713 = new GameObject(_0xd6c69d54, typeof(RectTransform));
        _0x23559713.transform.SetParent(_0x865cd978, false);
        RectTransform _0x41fb7532 = _0x23559713.GetComponent<RectTransform>();
        _0x41fb7532.anchorMin = _0x17f89d2b;
        _0x41fb7532.anchorMax = _0x17f89d2b;
        _0x41fb7532.pivot = new Vector2(0.5f, 0.5f);
        _0x41fb7532.anchoredPosition = _0xcfa019e3;
        _0x41fb7532.sizeDelta = _0xbed7c7e7;
        TextMeshProUGUI _0x70d0e78c = _0x23559713.AddComponent<TextMeshProUGUI>();
        if (_0x78618b30 != null)
            _0x70d0e78c.font = _0x78618b30;
        _0x70d0e78c.alignment = _0xf4d2ae8f;
        _0x70d0e78c.color = _0xba504893;
        _0x70d0e78c.raycastTarget = false;
        _0x70d0e78c.enableWordWrapping = false;
        _0x70d0e78c.overflowMode = TextOverflowModes.Overflow;
        _0x70d0e78c.enableAutoSizing = true;
        _0x70d0e78c.fontSizeMin = 24f;
        _0x70d0e78c.fontSizeMax = Mathf.Max(24f, _0x37172423);
        _0x70d0e78c.fontStyle = FontStyles.Bold;
        ApplyOutline(_0x70d0e78c, _0xba504893);
        return _0x70d0e78c;
    }

    // Reading fontMaterial clones the shared asset, so the project-wide font material
    // is untouched and this label alone gets the contrasting outline.
    public static void ApplyOutline(TMP_Text _0xe522346f, Color _0x9bd9864e)
    {
        if (_0xe522346f == null)
            return;
        Material _0x3b6c3854 = _0xe522346f.fontMaterial;
        if (_0x3b6c3854 == null)
            return;
        float _0xa65481b5 = (0.299f * _0x9bd9864e.r) + (0.587f * _0x9bd9864e.g) + (0.114f * _0x9bd9864e.b);
        Color _0x421df8a9 = _0xa65481b5 < 0.5f ? _0x9a8db30d.Cream : _0x9a8db30d.Ink;
        _0x3b6c3854.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x3b6c3854.SetColor(ShaderUtilities.ID_OutlineColor, _0x421df8a9);
        _0x3b6c3854.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.2f);
        _0x3b6c3854.SetFloat(ShaderUtilities.ID_FaceDilate, 0.16f);
    }

    public static string Clock(float _0xa6046ae0)
    {
        if (_0xa6046ae0 < 0f)
            _0xa6046ae0 = 0f;
        int _0xe4774948 = Mathf.CeilToInt(_0xa6046ae0);
        int _0x9bd11da3 = _0xe4774948 / 60;
        int _0x2458fe6f = _0xe4774948 % 60;
        return _0x9bd11da3.ToString() + _0x0ae1c51f._0x450ecd75(new byte[1] { 148 }, 174) + _0x2458fe6f.ToString(_0x0ae1c51f._0x450ecd75(new byte[2] { 65, 65 }, 113));
    }
}

internal static class _0x0ae1c51f
{
    internal static string _0x450ecd75(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}