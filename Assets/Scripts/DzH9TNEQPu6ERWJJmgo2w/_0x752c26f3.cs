using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The run HUD, built as its own objects inside the game panel - never content pushed
// into the template's placeholders (rule C.2). Numbers below are in the menu canvas
// reference units (1242 x 2688) the CanvasScaler already works in.
//
// Rule C.25 check for the row at y -266 / -290:
//   progress text  spans  96 .. 1040   (centre 568, width 944)
//   strike gutter  spans 1075 .. 1225  (centre 1150, width 150)
//   gap = 35 px, comfortably over the 24 px floor.
public sealed class _0x752c26f3 : MonoBehaviour
{
    private const float BarCentreX = -53f;
    private const float PanelWidth = 1242f;
    private Sprite[] _0xa70ef943;
    private Image[] _0x1614cc4a = new Image[3];
    [SerializeField]
    private Sprite _backIcon;
    private const float GutterCentreX = 529f;
    private TextMeshProUGUI _0x13f4a1f9;
    private TextMeshProUGUI _0x624d1f10;
    public void _0xdff1ffc9(int _0xea3743da, int _0xe2a317f5, int _0xa23b01dd)
    {
        this._0xa3076b25(0, _0xea3743da);
        this._0xa3076b25(1, _0xe2a317f5);
        this._0xa3076b25(2, _0xa23b01dd);
    }

    [SerializeField]
    private Sprite _plateSprite;
    [SerializeField]
    private Sprite _strikeSprite;
    private void _0x721c54cc()
    {
        if (this._0x624d1f10 != null)
            this._0x624d1f10.color = _0x9a8db30d.Alpha(_0x9a8db30d.Cream, _0x6268eeb2.HintFadedAlpha);
        if (this._0xff89951a != null)
            this._0xff89951a.color = _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.52f);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private Image _0x7fd7a736;
    private RectTransform _0x15f5dd21;
    private Image[] _0x754abad1 = new Image[3];
    private void _0xa3076b25(int _0x5f9df46c, int _0x73aa3be0)
    {
        if (_0x5f9df46c < 0 || _0x5f9df46c >= this._0x1614cc4a.Length)
            return;
        Image _0x3ad03f8d = this._0x1614cc4a[_0x5f9df46c];
        if (_0x3ad03f8d == null)
            return;
        if (_0x73aa3be0 < 0)
        {
            _0x3ad03f8d.enabled = false;
            if (this._0x754abad1[_0x5f9df46c] != null)
                this._0x754abad1[_0x5f9df46c].color = _0x9a8db30d.Steel;
            return;
        }

        if (this._0xa70ef943 != null && this._0xa70ef943.Length > 0)
        {
            Sprite _0x26444841 = this._0xa70ef943[_0x73aa3be0 % this._0xa70ef943.Length];
            if (_0x26444841 != null)
            {
                _0x3ad03f8d.sprite = _0x26444841;
                _0x3ad03f8d.preserveAspect = true;
            }
        }

        _0x3ad03f8d.enabled = _0x3ad03f8d.sprite != null;
        _0x3ad03f8d.color = Color.white;
        if (this._0x754abad1[_0x5f9df46c] != null)
            this._0x754abad1[_0x5f9df46c].color = _0x5f9df46c == 0 ? _0x9a8db30d.Gold : _0x9a8db30d.Crate(_0x73aa3be0);
    }

    private TextMeshProUGUI _0x7fd051bb;
    public void _0x7566c853(float _0x15b6eaf3)
    {
        if (this._0x7fd051bb == null)
            return;
        this._0x7fd051bb.text = _0x9ed53401.Clock(_0x15b6eaf3);
        this._0x7fd051bb.color = _0x15b6eaf3 <= 10f ? _0x9a8db30d.Red : _0x9a8db30d.Gold;
    }

    private Image _0x787d6d86;
    private Image _0xff89951a;
    public void _0x3636f6f3(int _0x73b4e136)
    {
        for (int _0x3c52922a = 0; _0x3c52922a < this._0x51a54b61.Length; _0x3c52922a++)
        {
            Image _0x55f1eb23 = this._0x51a54b61[_0x3c52922a];
            if (_0x55f1eb23 == null)
                continue;
            bool _0xbbbb1fed = _0x3c52922a < _0x73b4e136;
            _0x55f1eb23.color = _0xbbbb1fed ? _0x9a8db30d.Alpha(_0x9a8db30d.Steel, 0.5f) : _0x9a8db30d.Red;
        }
    }

    [SerializeField]
    private Sprite _pauseIcon;
    private const float BarWidth = 944f;
    public Transform _0x74083df0
    {
        get
        {
            return this._0x15f5dd21;
        }
    }

    public void _0x6a79f470()
    {
        if (this._0x787d6d86 == null)
            return;
        DOTween.Kill(this._0x787d6d86, true);
        this._0x787d6d86.color = _0x9a8db30d.Alpha(_0x9a8db30d.Red, 0.35f);
        this._0x787d6d86.DOFade(0f, 0.22f);
    }

    private Image[] _0x51a54b61 = new Image[_0x6268eeb2.StrikesMax];
    public void _0xdfeb293e(Transform _0x9337094d, Sprite[] _0x494afd2e, System.Action _0x543d6853, System.Action _0xed3b4f43)
    {
        this._0xa70ef943 = _0x494afd2e;
        this._0x15f5dd21 = _0x9dceb157.Fill(_0x9337094d, _0xa42ebde8._0x16b370af(new byte[10] { 71, 96, 123, 93, 96, 113, 71, 122, 122, 97 }, 21));
        // Back and pause live in the top corners. They are the only raycast targets in
        // the HUD, so nothing else can swallow a lane tap.
        Button _0x34feab38 = _0x9dceb157.Tap(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[7] { 91, 120, 122, 114, 77, 120, 105 }, 25), new Vector2(0f, 1f), new Vector2(96f, -120f), new Vector2(112f, 112f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 3.4f);
        _0x9dceb157.Picture(_0x34feab38.transform, _0xa42ebde8._0x16b370af(new byte[8] { 236, 207, 205, 197, 227, 207, 220, 197 }, 174), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(60f, 60f), this._backIcon, _0x9a8db30d.Gold);
        _0x34feab38.onClick.AddListener(() => _0x543d6853.Invoke());
        Button _0xbe22cfda = _0x9dceb157.Tap(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[8] { 156, 173, 185, 191, 169, 152, 173, 188 }, 204), new Vector2(1f, 1f), new Vector2(-96f, -120f), new Vector2(112f, 112f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 3.4f);
        _0x9dceb157.Picture(_0xbe22cfda.transform, _0xa42ebde8._0x16b370af(new byte[9] { 216, 233, 253, 251, 237, 197, 233, 250, 227 }, 136), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 56f), this._pauseIcon, _0x9a8db30d.Gold);
        _0xbe22cfda.onClick.AddListener(() => _0xed3b4f43.Invoke());
        // Route clock. The box is sized for the widest value the counter can show.
        _0x9dceb157.Plate(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[10] { 213, 250, 249, 245, 253, 198, 250, 247, 226, 243 }, 150), new Vector2(0.5f, 1f), new Vector2(0f, -124f), new Vector2(420f, 112f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.78f), 3.4f);
        this._0x7fd051bb = _0x9ed53401.Label(this._0x15f5dd21, this._font, _0xa42ebde8._0x16b370af(new byte[10] { 209, 254, 253, 241, 249, 196, 243, 254, 231, 247 }, 146), new Vector2(0.5f, 1f), new Vector2(0f, -124f), new Vector2(380f, 96f), 86f, _0x9a8db30d.Gold, TextAlignmentOptions.Center);
        this._0x7fd051bb.text = _0xa42ebde8._0x16b370af(new byte[4] { 65, 75, 65, 65 }, 113);
        this._0x13f4a1f9 = _0x9ed53401.Label(this._0x15f5dd21, this._font, _0xa42ebde8._0x16b370af(new byte[13] { 237, 207, 210, 218, 207, 216, 206, 206, 235, 220, 209, 200, 216 }, 189), new Vector2(0.5f, 1f), new Vector2(BarCentreX, -266f), new Vector2(BarWidth, 54f), 40f, _0x9a8db30d.Cream, TextAlignmentOptions.Left);
        this._0x13f4a1f9.text = _0x9ed53401.Pair(_0xa42ebde8._0x16b370af(new byte[6] { 44, 61, 46, 59, 42, 60 }, 111), 0, _0x6268eeb2.CratesPerRoute);
        this._0x7fd7a736 = _0x9dceb157.Strip(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[13] { 106, 72, 85, 93, 72, 95, 73, 73, 105, 78, 72, 83, 74 }, 58), new Vector2(0.5f, 1f), new Vector2(BarCentreX, -312f), new Vector2(BarWidth, 22f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.9f), _0x9a8db30d.Teal);
        _0x9dceb157.SetBar(this._0x7fd7a736, 0f, BarWidth);
        // Strike gutter: three marks in their own x band, far clear of the text column.
        RectTransform _0x6af70f1b = _0x9dceb157.Node(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[12] { 217, 254, 248, 227, 225, 239, 205, 255, 254, 254, 239, 248 }, 138), new Vector2(0.5f, 1f), new Vector2(GutterCentreX, -290f), new Vector2(150f, 54f));
        for (int _0x794cf24f = 0; _0x794cf24f < _0x6268eeb2.StrikesMax; _0x794cf24f++)
        {
            float _0xfb148dc3 = -52f + (_0x794cf24f * 52f);
            this._0x51a54b61[_0x794cf24f] = _0x9dceb157.Picture(_0x6af70f1b, _0xa42ebde8._0x16b370af(new byte[10] { 44, 11, 13, 22, 20, 26, 50, 30, 13, 20 }, 127) + _0x794cf24f.ToString(), new Vector2(0.5f, 0.5f), new Vector2(_0xfb148dc3, 0f), new Vector2(46f, 46f), this._strikeSprite, _0x9a8db30d.Red);
        }

        // Delivery queue: the head crate sits in a gold ring, the next two behind it.
        _0x9ed53401.Label(this._0x15f5dd21, this._font, _0xa42ebde8._0x16b370af(new byte[12] { 234, 206, 222, 206, 222, 248, 218, 203, 207, 210, 212, 213 }, 187), new Vector2(0.5f, 1f), new Vector2(-155f, -400f), new Vector2(220f, 42f), 30f, _0x9a8db30d.Sand, TextAlignmentOptions.Center).text = _0xa42ebde8._0x16b370af(new byte[4] { 97, 106, 119, 123 }, 47);
        for (int _0xb4c2fe18 = 0; _0xb4c2fe18 < 3; _0xb4c2fe18++)
        {
            float _0xa3d396ce = _0xb4c2fe18 == 0 ? 140f : 118f;
            float _0xed0b1123 = -155f + (_0xb4c2fe18 * 155f);
            Image _0x3eca84c1 = _0x9dceb157.Plate(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[9] { 59, 31, 15, 31, 15, 41, 2, 3, 26 }, 106) + _0xb4c2fe18.ToString(), new Vector2(0.5f, 1f), new Vector2(_0xed0b1123, -470f), new Vector2(_0xa3d396ce, _0xa3d396ce), this._plateSprite, _0xb4c2fe18 == 0 ? _0x9a8db30d.Gold : _0x9a8db30d.Steel, 2.2f);
            _0x9dceb157.Plate(_0x3eca84c1.transform, _0xa42ebde8._0x16b370af(new byte[14] { 200, 236, 252, 236, 252, 218, 241, 240, 233, 208, 247, 247, 252, 235 }, 153) + _0xb4c2fe18.ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xa3d396ce - 12f, _0xa3d396ce - 12f), this._plateSprite, _0x9a8db30d.Ink, 2.2f);
            this._0x754abad1[_0xb4c2fe18] = _0x3eca84c1;
            this._0x1614cc4a[_0xb4c2fe18] = _0x9dceb157.Picture(_0x3eca84c1.transform, _0xa42ebde8._0x16b370af(new byte[12] { 36, 0, 16, 0, 16, 54, 29, 28, 5, 52, 7, 1 }, 117) + _0xb4c2fe18.ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xa3d396ce - 34f, _0xa3d396ce - 34f), null, Color.white);
            // An Image with no sprite is drawn as a solid white rectangle, so it stays
            // switched off until a real crate sprite is assigned (rule B.1).
            this._0x1614cc4a[_0xb4c2fe18].enabled = false;
        }

        // Gesture caption (rule C.6). It never disappears - it only dims - so the review
        // album always carries the control explanation.
        this._0xff89951a = _0x9dceb157.Plate(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[9] { 11, 42, 45, 55, 19, 47, 34, 55, 38 }, 67), new Vector2(0.5f, 0f), new Vector2(0f, 228f), new Vector2(1080f, 76f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.72f), 3.4f);
        this._0x624d1f10 = _0x9ed53401.Label(this._0x15f5dd21, this._font, _0xa42ebde8._0x16b370af(new byte[9] { 139, 170, 173, 183, 149, 162, 175, 182, 166 }, 195), new Vector2(0.5f, 0f), new Vector2(0f, 228f), new Vector2(1040f, 60f), 34f, _0x9a8db30d.Cream, TextAlignmentOptions.Center);
        this._0x624d1f10.text = _0xa42ebde8._0x16b370af(new byte[40] { 117, 113, 111, 118, 99, 6, 105, 116, 6, 114, 103, 118, 6, 106, 99, 96, 114, 6, 9, 6, 116, 111, 97, 110, 114, 6, 114, 105, 6, 101, 110, 103, 104, 97, 99, 6, 106, 103, 104, 99 }, 38);
        this._0x787d6d86 = _0x9dceb157.Plate(this._0x15f5dd21, _0xa42ebde8._0x16b370af(new byte[12] { 221, 249, 227, 228, 241, 251, 245, 214, 252, 241, 227, 248 }, 144), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(PanelWidth + 60f, 2748f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Red, 0f), 3f);
        this._0x787d6d86.raycastTarget = false;
        DOVirtual.DelayedCall(_0x6268eeb2.HintSolidTime, () => this._0x721c54cc());
    }

    public void _0x80e4eb50()
    {
        if (this._0x13f4a1f9 == null)
            return;
        Transform _0x30ee1482 = this._0x13f4a1f9.transform;
        DOTween.Kill(_0x30ee1482, true);
        _0x30ee1482.localScale = Vector3.one;
        _0x30ee1482.DOPunchScale(Vector3.one * 0.08f, 0.26f, 6, 0.6f);
    }

    public void _0x9e048bb3(int _0xb38cb0a0, int _0x166eafbd)
    {
        if (this._0x13f4a1f9 != null)
            this._0x13f4a1f9.text = _0x9ed53401.Pair(_0xa42ebde8._0x16b370af(new byte[6] { 16, 1, 18, 7, 22, 0 }, 83), _0xb38cb0a0, _0x166eafbd);
        if (this._0x7fd7a736 != null)
            _0x9dceb157.SetBar(this._0x7fd7a736, _0x166eafbd <= 0 ? 0f : (float)_0xb38cb0a0 / (float)_0x166eafbd, BarWidth);
    }
}

internal static class _0xa42ebde8
{
    internal static string _0x16b370af(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}