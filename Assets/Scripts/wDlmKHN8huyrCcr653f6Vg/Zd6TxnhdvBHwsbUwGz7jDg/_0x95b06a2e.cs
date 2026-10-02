using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x95b06a2e : MonoBehaviour
{
    private static void OrientationChanged()
    {
        _0x4669ae70 = Screen.orientation;
        _0x3cdf552a.x = Screen.width;
        _0x3cdf552a.y = Screen.height;
        _0x07599514.Invoke();
    }

    private void Awake()
    {
        if (!_0x342967a3.Contains(this))
            _0x342967a3.Add(this);
        this._0xd834f158 = this.GetComponent<Canvas>();
        this._0x34f9bb3e = this.GetComponent<RectTransform>();
        this._0xadf61c88 = this.transform.Find(_0x467934d9._0x4ef1ab0c(new byte[8] { 216, 234, 237, 238, 202, 249, 238, 234 }, 139)) as RectTransform;
        if (!_0x4b3994a8)
        {
            _0x4669ae70 = Screen.orientation;
            _0x3cdf552a.x = Screen.width;
            _0x3cdf552a.y = Screen.height;
            _0x7898dba6 = Screen.safeArea;
            _0x4b3994a8 = true;
        }

        this._0x2bde57aa();
    }

    private static readonly List<_0x95b06a2e> _0x342967a3 = new();
    private static Vector2 _0x3cdf552a = Vector2.zero;
    private static Rect _0x7898dba6 = Rect.zero;
    private static UnityEvent _0x07599514 = new();
    private static bool _0x4b3994a8;
    private void Update()
    {
        if (_0x342967a3[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x4669ae70)
            OrientationChanged();
        if (Screen.safeArea != _0x7898dba6)
            SafeAreaChanged();
        if (Screen.width != _0x3cdf552a.x || Screen.height != _0x3cdf552a.y)
            ResolutionChanged();
    }

    private RectTransform _0xadf61c88;
    private RectTransform _0x34f9bb3e;
    private static ScreenOrientation _0x4669ae70 = ScreenOrientation.LandscapeLeft;
    private void _0x2bde57aa()
    {
        if (this._0xadf61c88 == null)
            return;
        Rect _0xb47fd7a5 = Screen.safeArea;
        Vector2 _0x02ede4b5 = _0xb47fd7a5.position;
        Vector2 _0xaecfa260 = _0xb47fd7a5.position + _0xb47fd7a5.size;
        _0x02ede4b5.x /= this._0xd834f158.pixelRect.width;
        _0x02ede4b5.y /= this._0xd834f158.pixelRect.height;
        _0xaecfa260.x /= this._0xd834f158.pixelRect.width;
        _0xaecfa260.y /= this._0xd834f158.pixelRect.height;
        this._0xadf61c88.anchorMin = _0x02ede4b5;
        this._0xadf61c88.anchorMax = _0xaecfa260;
    }

    private static void ResolutionChanged()
    {
        _0x3cdf552a.x = Screen.width;
        _0x3cdf552a.y = Screen.height;
        _0x07599514.Invoke();
    }

    private Canvas _0xd834f158;
    private void OnDestroy()
    {
        if (_0x342967a3 != null && _0x342967a3.Contains(this))
            _0x342967a3.Remove(this);
    }

    private static void SafeAreaChanged()
    {
        _0x7898dba6 = Screen.safeArea;
        for (int _0xc4b87613 = 0; _0xc4b87613 < _0x342967a3.Count; _0xc4b87613++)
            _0x342967a3[_0xc4b87613]._0x2bde57aa();
    }
}

internal static class _0x467934d9
{
    internal static string _0x4ef1ab0c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}