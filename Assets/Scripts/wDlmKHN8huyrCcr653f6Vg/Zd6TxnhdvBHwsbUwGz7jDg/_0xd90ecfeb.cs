using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xd90ecfeb : MonoBehaviour
{
    private static Rect _0x1f6b0285 = Rect.zero;
    private static void OrientationChanged()
    {
        _0x33cb5c42 = Screen.orientation;
        _0xd6796efc.x = Screen.width;
        _0xd6796efc.y = Screen.height;
        _0x1f6b0285 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xa6ec0137.Invoke();
    }

    private static void ResolutionChanged()
    {
        _0xd6796efc.x = Screen.width;
        _0xd6796efc.y = Screen.height;
        _0x1f6b0285 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xa6ec0137.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0x1f6b0285 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static UnityEvent _0xa6ec0137 = new();
    private static ScreenOrientation _0x33cb5c42 = ScreenOrientation.LandscapeLeft;
    private void Update()
    {
        if (_0x94a6d3c0.Count == 0 || _0x94a6d3c0[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x33cb5c42)
            OrientationChanged();
        if (Screen.safeArea != _0x1f6b0285)
            SafeAreaChanged();
        if (Screen.width != _0xd6796efc.x || Screen.height != _0xd6796efc.y)
            ResolutionChanged();
    }

    private void OnDestroy()
    {
        if (_0x94a6d3c0 != null && _0x94a6d3c0.Contains(this))
            _0x94a6d3c0.Remove(this);
    }

    private CanvasScaler _0x5069d452;
    private void Awake()
    {
        if (!_0x94a6d3c0.Contains(this))
            _0x94a6d3c0.Add(this);
        this._0xecdbf71a = this.GetComponent<Canvas>();
        this._0x5069d452 = this.GetComponent<CanvasScaler>();
        if (this._0x5069d452 != null)
            this._0xca639e6c = this._0x5069d452.referenceResolution;
        this._0x42b9cd78 = this.GetComponent<RectTransform>();
        this._0xefb4d6f6 = this.transform.Find(_0xda277d6d._0xd1b1784b(new byte[8] { 239, 221, 218, 217, 253, 206, 217, 221 }, 188)) as RectTransform;
        if (!_0x594b3eac)
        {
            _0x33cb5c42 = Screen.orientation;
            _0xd6796efc.x = Screen.width;
            _0xd6796efc.y = Screen.height;
            _0x1f6b0285 = Screen.safeArea;
            _0x594b3eac = true;
        }

        this._0x4f9d7e97();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x8e91d3ac = 0; _0x8e91d3ac < _0x94a6d3c0.Count; _0x8e91d3ac++)
            _0x94a6d3c0[_0x8e91d3ac]._0x4f9d7e97();
    }

    private RectTransform _0x42b9cd78;
    private Canvas _0xecdbf71a;
    private Vector2 _0xca639e6c;
    private RectTransform _0xefb4d6f6;
    private static Vector2 _0xd6796efc = Vector2.zero;
    private static readonly List<_0xd90ecfeb> _0x94a6d3c0 = new();
    private void Start()
    {
    }

    private static bool _0x594b3eac;
    private void _0x4f9d7e97()
    {
        if (this._0xefb4d6f6 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xb3add834 = Screen.safeArea;
        Vector2 _0xaa452228 = _0xb3add834.position;
        Vector2 _0x5d8d3872 = _0xb3add834.position + _0xb3add834.size;
        _0xaa452228.x /= screenWidth;
        _0xaa452228.y /= screenHeight;
        _0x5d8d3872.x /= screenWidth;
        _0x5d8d3872.y /= screenHeight;
        this._0xefb4d6f6.anchorMin = _0xaa452228;
        this._0xefb4d6f6.anchorMax = _0x5d8d3872;
        this._0xefb4d6f6.offsetMin = Vector2.zero;
        this._0xefb4d6f6.offsetMax = Vector2.zero;
        if (this._0x5069d452 == null)
            return;
        Vector2 _0x97f4c3f1 = _0x5d8d3872 - _0xaa452228;
        float _0x0fcec43a = 2f - _0x97f4c3f1.x;
        float _0x9124beaf = 2f - _0x97f4c3f1.y;
        this._0x5069d452.referenceResolution = this._0xca639e6c * new Vector2(_0x0fcec43a, _0x9124beaf);
    }
}

internal static class _0xda277d6d
{
    internal static string _0xd1b1784b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}