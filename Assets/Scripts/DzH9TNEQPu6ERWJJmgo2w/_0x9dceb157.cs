using UnityEngine;
using UnityEngine.UI;

// Small UGUI factory. Both scenes build their UI with it, so the chrome is identical
// everywhere and the hierarchy order is explicit: a node created LATER draws ON TOP of
// its earlier siblings (rule C.13), which is why every builder here appends the label
// after its own background.
public static class _0x9dceb157
{
    public static Image Picture(Transform _0x283db011, string _0xbabe9a8b, Vector2 _0x05d3765f, Vector2 _0xe5411fa2, Vector2 _0x6e343f75, Sprite _0x9af7b0c1, Color _0x3a0afa75)
    {
        RectTransform _0xeeb05a96 = Node(_0x283db011, _0xbabe9a8b, _0x05d3765f, _0xe5411fa2, _0x6e343f75);
        Image _0x92160e1b = _0xeeb05a96.gameObject.AddComponent<Image>();
        _0x92160e1b.sprite = _0x9af7b0c1;
        _0x92160e1b.preserveAspect = true;
        _0x92160e1b.color = _0x3a0afa75;
        _0x92160e1b.raycastTarget = false;
        return _0x92160e1b;
    }

    // A pressable surface. targetGraphic points at the VISIBLE fill (not a transparent
    // hit layer) so the press tint actually reads on screen.
    public static Button Tap(Transform _0x833718d7, string _0x2e7089c6, Vector2 _0xf810e099, Vector2 _0xb27290bf, Vector2 _0x3fc609dd, Sprite _0x9d82c279, Color _0x05026b71, Color _0x4368a68b, float _0xc17370ff)
    {
        Image _0x3c192072 = Plate(_0x833718d7, _0x2e7089c6, _0xf810e099, _0xb27290bf, _0x3fc609dd, _0x9d82c279, _0x05026b71, _0xc17370ff);
        _0x3c192072.raycastTarget = true;
        Image _0x57cda332 = Plate(_0x3c192072.transform, _0x2e7089c6 + _0xadae26b2._0xc172feff(new byte[5] { 165, 156, 155, 153, 159 }, 250), new Vector2(0.5f, 0.5f), Vector2.zero, _0x3fc609dd - new Vector2(10f, 10f), _0x9d82c279, _0x4368a68b, _0xc17370ff);
        Button _0x24c6efdc = _0x3c192072.gameObject.AddComponent<Button>();
        _0x24c6efdc.targetGraphic = _0x57cda332;
        ColorBlock _0xf6045ec9 = _0x24c6efdc.colors;
        _0xf6045ec9.normalColor = Color.white;
        _0xf6045ec9.highlightedColor = Color.white;
        _0xf6045ec9.pressedColor = new Color(0.62f, 0.62f, 0.62f, 1f);
        _0xf6045ec9.selectedColor = Color.white;
        _0xf6045ec9.disabledColor = new Color(0.5f, 0.5f, 0.5f, 1f);
        _0x24c6efdc.colors = _0xf6045ec9;
        return _0x24c6efdc;
    }

    // A themed card: palette-coloured body inside a visible edge ring.
    public static RectTransform Card(Transform _0xc8b65aa9, string _0xecb98ad6, Vector2 _0x7383540d, Vector2 _0x93a070a4, Vector2 _0xb60bc820, Sprite _0xbd6d47c2, Color _0xda4fafd2, Color _0x277b94c6, float _0xc08c3e38)
    {
        Image _0xb1117c3b = Plate(_0xc8b65aa9, _0xecb98ad6, _0x7383540d, _0x93a070a4, _0xb60bc820, _0xbd6d47c2, _0xda4fafd2, _0xc08c3e38);
        Image _0x12c66445 = Plate(_0xb1117c3b.transform, _0xecb98ad6 + _0xadae26b2._0xc172feff(new byte[5] { 183, 138, 135, 140, 145 }, 232), new Vector2(0.5f, 0.5f), Vector2.zero, _0xb60bc820 - new Vector2(10f, 10f), _0xbd6d47c2, _0x277b94c6, _0xc08c3e38);
        return _0x12c66445.rectTransform;
    }

    public static void SetBar(Image _0xfbbbf111, float _0x6f514b94, float _0x988622d6)
    {
        if (_0xfbbbf111 == null)
            return;
        float _0x274de9d7 = Mathf.Clamp01(_0x6f514b94);
        RectTransform _0x06b49619 = _0xfbbbf111.rectTransform;
        _0x06b49619.sizeDelta = new Vector2(Mathf.Max(8f, (_0x988622d6 - 6f) * _0x274de9d7), _0x06b49619.sizeDelta.y);
    }

    // A rounded surface. The sprite is 9-sliced, so stretching it is the point and
    // preserveAspect would be wrong here; roundness comes from the slice multiplier
    // (lower = rounder).
    public static Image Plate(Transform _0x574606fe, string _0x39c7c316, Vector2 _0x5b8696e4, Vector2 _0x976b2f2a, Vector2 _0x3bb5943d, Sprite _0xa27d5947, Color _0xa5429389, float _0x3a63ae4e)
    {
        RectTransform _0x0cda156a = Node(_0x574606fe, _0x39c7c316, _0x5b8696e4, _0x976b2f2a, _0x3bb5943d);
        Image _0x23619899 = _0x0cda156a.gameObject.AddComponent<Image>();
        _0x23619899.sprite = _0xa27d5947;
        _0x23619899.type = Image.Type.Sliced;
        _0x23619899.pixelsPerUnitMultiplier = _0x3a63ae4e;
        _0x23619899.color = _0xa5429389;
        _0x23619899.raycastTarget = false;
        return _0x23619899;
    }

    public static RectTransform Fill(Transform _0x9103aa9e, string _0x95134879)
    {
        GameObject _0xbbd95083 = new GameObject(_0x95134879, typeof(RectTransform));
        _0xbbd95083.transform.SetParent(_0x9103aa9e, false);
        RectTransform _0x86192672 = _0xbbd95083.GetComponent<RectTransform>();
        _0x86192672.anchorMin = Vector2.zero;
        _0x86192672.anchorMax = Vector2.one;
        _0x86192672.pivot = new Vector2(0.5f, 0.5f);
        _0x86192672.offsetMin = Vector2.zero;
        _0x86192672.offsetMax = Vector2.zero;
        return _0x86192672;
    }

    // Horizontal progress strip: a dark track with a fill pinned to its left edge.
    // The caller moves the fill with SetBar below.
    public static Image Strip(Transform _0xfa83479e, string _0x6ecc34b2, Vector2 _0x8fbce2cd, Vector2 _0x8d45ac71, Vector2 _0x5c8a5a74, Sprite _0x59aacb25, Color _0x576fc967, Color _0x8340eec4)
    {
        Image _0xf5115b77 = Plate(_0xfa83479e, _0x6ecc34b2, _0x8fbce2cd, _0x8d45ac71, _0x5c8a5a74, _0x59aacb25, _0x576fc967, 6f);
        RectTransform _0x101d2bb6 = Node(_0xf5115b77.transform, _0x6ecc34b2 + _0xadae26b2._0xc172feff(new byte[5] { 205, 244, 251, 254, 254 }, 146), new Vector2(0f, 0.5f), new Vector2(0f, 0f), new Vector2(_0x5c8a5a74.x, _0x5c8a5a74.y - 6f));
        _0x101d2bb6.pivot = new Vector2(0f, 0.5f);
        _0x101d2bb6.anchoredPosition = new Vector2(3f, 0f);
        Image _0x58ac01d5 = _0x101d2bb6.gameObject.AddComponent<Image>();
        _0x58ac01d5.sprite = _0x59aacb25;
        _0x58ac01d5.type = Image.Type.Sliced;
        _0x58ac01d5.pixelsPerUnitMultiplier = 6f;
        _0x58ac01d5.color = _0x8340eec4;
        _0x58ac01d5.raycastTarget = false;
        return _0x58ac01d5;
    }

    public static RectTransform Node(Transform _0x37fe2b99, string _0xedca6b0a, Vector2 _0x0cc9c5c2, Vector2 _0x264e3a5e, Vector2 _0x8997340a)
    {
        GameObject _0xbf50d776 = new GameObject(_0xedca6b0a, typeof(RectTransform));
        _0xbf50d776.transform.SetParent(_0x37fe2b99, false);
        RectTransform _0x012f4708 = _0xbf50d776.GetComponent<RectTransform>();
        _0x012f4708.anchorMin = _0x0cc9c5c2;
        _0x012f4708.anchorMax = _0x0cc9c5c2;
        _0x012f4708.pivot = new Vector2(0.5f, 0.5f);
        _0x012f4708.anchoredPosition = _0x264e3a5e;
        _0x012f4708.sizeDelta = _0x8997340a;
        return _0x012f4708;
    }

    public static void HideChildren(Transform _0x8a1c04c4)
    {
        if (_0x8a1c04c4 == null)
            return;
        for (int _0x80e132c7 = 0; _0x80e132c7 < _0x8a1c04c4.childCount; _0x80e132c7++)
        {
            GameObject _0x6f227cd7 = _0x8a1c04c4.GetChild(_0x80e132c7).gameObject;
            if (_0x6f227cd7 != null)
                _0x6f227cd7.SetActive(false);
        }
    }
}

internal static class _0xadae26b2
{
    internal static string _0xc172feff(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}