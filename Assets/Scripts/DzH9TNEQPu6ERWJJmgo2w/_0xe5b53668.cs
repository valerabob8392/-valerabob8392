using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Win / lose / pause are dressed whole, not just re-texted (rule C.3): the template's
// own card, its static "Score:" / "Reward:" rows and its close button (whose Image has
// no sprite, i.e. a white square) are switched off, and this game's card is built in
// their place with palette colours and a real cross icon from a serialized sprite.
public sealed class _0xe5b53668 : MonoBehaviour
{
    public void _0x89a76e18(int _0xe72c303f, float _0xe19c7729)
    {
        this._0x3fa07c5c(this._0xfb6effeb, _0x655c16d2._0x8ead6ad1(new byte[12] { 60, 33, 59, 58, 43, 78, 62, 47, 59, 61, 43, 42 }, 110), _0x9a8db30d.Gold, _0x9ed53401.Pair(_0x655c16d2._0x8ead6ad1(new byte[6] { 87, 70, 85, 64, 81, 71 }, 20), _0xe72c303f, _0x6268eeb2.CratesPerRoute), _0x655c16d2._0x8ead6ad1(new byte[10] { 64, 93, 89, 81, 52, 88, 81, 82, 64, 52 }, 20) + _0x9ed53401.Clock(_0xe19c7729) + _0x655c16d2._0x8ead6ad1(new byte[34] { 124, 37, 33, 63, 38, 51, 86, 57, 36, 86, 34, 55, 38, 86, 58, 51, 48, 34, 86, 89, 86, 36, 63, 49, 62, 34, 86, 34, 57, 86, 59, 57, 32, 51 }, 118), _0x655c16d2._0x8ead6ad1(new byte[6] { 250, 237, 251, 253, 229, 237 }, 168));
    }

    public void _0x2099ba79(string _0x8c3d44e5, int _0x89f6fec1, int _0xa9ea082d, int _0xdd7b9533)
    {
        this._0x3fa07c5c(this._0xd3d2faab, _0x8c3d44e5, _0x9a8db30d.Red, _0x9ed53401.Pair("", _0x89f6fec1, _0x6268eeb2.CratesPerRoute).Trim() + _0x655c16d2._0x8ead6ad1(new byte[7] { 49, 82, 67, 80, 69, 84, 66 }, 17), _0x655c16d2._0x8ead6ad1(new byte[9] { 241, 243, 243, 229, 226, 241, 243, 233, 144 }, 176) + _0xa9ea082d.ToString() + _0x655c16d2._0x8ead6ad1(new byte[14] { 65, 110, 38, 33, 55, 48, 68, 55, 48, 54, 33, 37, 47, 68 }, 100) + _0xdd7b9533.ToString(), _0x655c16d2._0x8ead6ad1(new byte[9] { 236, 235, 240, 158, 255, 249, 255, 247, 240 }, 190));
    }

    private const float CardHeight = 1180f;
    private const float CardWidth = 1020f;
    [SerializeField]
    private Sprite _plateSprite;
    private sealed class _0xfae56bc0
    {
        public TextMeshProUGUI Header;
        public TextMeshProUGUI Main;
        public TextMeshProUGUI Extra;
        public TextMeshProUGUI FirstLabel;
    }

    public void _0x1ae0ab6c(_0xc36ede33 _0x81b7b7ee, System.Action _0x94ec9676, System.Action _0xe4371c7d, System.Action _0x8e7657a5)
    {
        this._0xfb6effeb = this._0x4c50de19(_0x81b7b7ee, _0x655c16d2._0x8ead6ad1(new byte[5] { 203, 218, 206, 200, 222 }, 155), _0x9a8db30d.Gold, null, _0x655c16d2._0x8ead6ad1(new byte[12] { 245, 232, 242, 243, 226, 135, 247, 230, 242, 244, 226, 227 }, 167), _0x655c16d2._0x8ead6ad1(new byte[6] { 175, 184, 174, 168, 176, 184 }, 253), _0x655c16d2._0x8ead6ad1(new byte[4] { 39, 47, 36, 63 }, 106), _0x94ec9676, _0xe4371c7d, _0x8e7657a5);
    }

    [SerializeField]
    private Sprite _cartSprite;
    public void _0x42492dbe(int _0x82b619f4, int _0xe1e01945, int _0x3688a01b, string _0x3120c8e9)
    {
        this._0x3fa07c5c(this._0x6affe71c, _0x655c16d2._0x8ead6ad1(new byte[15] { 112, 109, 119, 118, 103, 2, 102, 103, 110, 107, 116, 103, 112, 103, 102 }, 34), _0x9a8db30d.Green, _0x9ed53401.Pair("", _0x82b619f4, _0x6268eeb2.CratesPerRoute).Trim() + _0x655c16d2._0x8ead6ad1(new byte[7] { 100, 7, 22, 5, 16, 1, 23 }, 68), _0x655c16d2._0x8ead6ad1(new byte[9] { 118, 116, 116, 98, 101, 118, 116, 110, 23 }, 55) + _0xe1e01945.ToString() + _0x655c16d2._0x8ead6ad1(new byte[14] { 161, 142, 198, 193, 215, 208, 164, 215, 208, 214, 193, 197, 207, 164 }, 132) + _0x3688a01b.ToString(), _0x3120c8e9);
    }

    public void _0x1462ac28(_0xc36ede33 _0x92eb3b49, System.Action _0x7cc8ec55, System.Action _0xa5d34856, System.Action _0x0b5a74bb)
    {
        this._0x6affe71c = this._0x4c50de19(_0x92eb3b49, _0x655c16d2._0x8ead6ad1(new byte[3] { 146, 140, 139 }, 197), _0x9a8db30d.Green, this._cartSprite, _0x655c16d2._0x8ead6ad1(new byte[15] { 190, 163, 185, 184, 169, 204, 168, 169, 160, 165, 186, 169, 190, 169, 168 }, 236), _0x655c16d2._0x8ead6ad1(new byte[10] { 65, 74, 87, 91, 47, 93, 64, 90, 91, 74 }, 15), _0x655c16d2._0x8ead6ad1(new byte[4] { 133, 141, 134, 157 }, 200), _0x7cc8ec55, _0xa5d34856, _0x0b5a74bb);
    }

    private _0xfae56bc0 _0xfb6effeb;
    public void _0xce5a35de(_0xc36ede33 _0x0d749eed, System.Action _0x9a2d79eb, System.Action _0x705204be, System.Action _0xab5a14bd)
    {
        this._0xd3d2faab = this._0x4c50de19(_0x0d749eed, _0x655c16d2._0x8ead6ad1(new byte[4] { 60, 63, 35, 53 }, 112), _0x9a8db30d.Red, this._hazardSprite, _0x655c16d2._0x8ead6ad1(new byte[13] { 87, 84, 90, 95, 59, 72, 88, 73, 90, 75, 75, 94, 95 }, 27), _0x655c16d2._0x8ead6ad1(new byte[9] { 246, 241, 234, 132, 229, 227, 229, 237, 234 }, 164), _0x655c16d2._0x8ead6ad1(new byte[4] { 62, 54, 61, 38 }, 115), _0x9a2d79eb, _0x705204be, _0xab5a14bd);
    }

    [SerializeField]
    private Sprite _hazardSprite;
    private _0xfae56bc0 _0x4c50de19(_0xc36ede33 _0xa6acad41, string _0xe50a27f1, Color _0xd9526cbf, Sprite _0x0a6af468, string _0x8775ea71, string _0x2efd3346, string _0x6dbf28c7, System.Action _0x545a13b2, System.Action _0x92c5a4dd, System.Action _0xbea37767)
    {
        if (_0xa6acad41 == null || _0xa6acad41.Content == null)
            return null;
        Transform _0xf9eb3109 = _0xa6acad41.Content.transform;
        _0x9dceb157.HideChildren(_0xf9eb3109);
        RectTransform _0x5aa3d798 = _0x9dceb157.Card(_0xf9eb3109, _0x655c16d2._0x8ead6ad1(new byte[4] { 162, 128, 147, 133 }, 225) + _0xe50a27f1, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(CardWidth, CardHeight), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 3.4f);
        _0xfae56bc0 _0xb6db196c = new _0xfae56bc0();
        _0xb6db196c.Header = _0x9ed53401.Label(_0x5aa3d798, this._font, _0x655c16d2._0x8ead6ad1(new byte[6] { 4, 41, 45, 40, 41, 62 }, 76) + _0xe50a27f1, new Vector2(0.5f, 1f), new Vector2(0f, -200f), new Vector2(900f, 100f), 64f, _0xd9526cbf, TextAlignmentOptions.Center);
        _0xb6db196c.Header.text = _0x8775ea71;
        if (_0x0a6af468 != null)
            _0x9dceb157.Picture(_0x5aa3d798, _0x655c16d2._0x8ead6ad1(new byte[3] { 16, 35, 37 }, 81) + _0xe50a27f1, new Vector2(0.5f, 1f), new Vector2(0f, -420f), new Vector2(300f, 300f), _0x0a6af468, Color.white);
        _0xb6db196c.Main = _0x9ed53401.Label(_0x5aa3d798, this._font, _0x655c16d2._0x8ead6ad1(new byte[4] { 55, 27, 19, 20 }, 122) + _0xe50a27f1, new Vector2(0.5f, 0.5f), new Vector2(0f, -40f), new Vector2(900f, 90f), 52f, _0x9a8db30d.Gold, TextAlignmentOptions.Center);
        _0xb6db196c.Main.text = "";
        _0xb6db196c.Extra = _0x9ed53401.Label(_0x5aa3d798, this._font, _0x655c16d2._0x8ead6ad1(new byte[5] { 60, 1, 13, 11, 24 }, 121) + _0xe50a27f1, new Vector2(0.5f, 0.5f), new Vector2(0f, -170f), new Vector2(900f, 140f), 38f, _0x9a8db30d.Cream, TextAlignmentOptions.Center);
        _0xb6db196c.Extra.text = "";
        Button _0x97ed8398 = _0x9dceb157.Tap(_0x5aa3d798, _0x655c16d2._0x8ead6ad1(new byte[5] { 44, 3, 24, 25, 30 }, 106) + _0xe50a27f1, new Vector2(0.5f, 0f), new Vector2(0f, 260f), new Vector2(720f, 140f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.GoldDeep, 3.4f);
        _0xb6db196c.FirstLabel = _0x9ed53401.Label(_0x97ed8398.transform, this._font, _0x655c16d2._0x8ead6ad1(new byte[10] { 29, 50, 41, 40, 47, 23, 58, 57, 62, 55 }, 91) + _0xe50a27f1, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(640f, 90f), 54f, _0x9a8db30d.Cream, TextAlignmentOptions.Center);
        _0xb6db196c.FirstLabel.text = _0x2efd3346;
        _0x97ed8398.onClick.AddListener(() => _0x545a13b2.Invoke());
        Button _0x78420a91 = _0x9dceb157.Tap(_0x5aa3d798, _0x655c16d2._0x8ead6ad1(new byte[6] { 5, 51, 53, 57, 56, 50 }, 86) + _0xe50a27f1, new Vector2(0.5f, 0f), new Vector2(0f, 100f), new Vector2(720f, 124f), this._plateSprite, _0x9a8db30d.Sand, _0x9a8db30d.Steel, 3.4f);
        _0x9ed53401.Label(_0x78420a91.transform, this._font, _0x655c16d2._0x8ead6ad1(new byte[11] { 170, 156, 154, 150, 151, 157, 181, 152, 155, 156, 149 }, 249) + _0xe50a27f1, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(640f, 80f), 46f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x6dbf28c7;
        _0x78420a91.onClick.AddListener(() => _0x92c5a4dd.Invoke());
        Button _0xcc9a45ae = _0x9dceb157.Tap(_0x5aa3d798, _0x655c16d2._0x8ead6ad1(new byte[5] { 144, 191, 188, 160, 182 }, 211) + _0xe50a27f1, new Vector2(1f, 1f), new Vector2(-56f, -56f), new Vector2(104f, 104f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 2.2f);
        _0x9dceb157.Picture(_0xcc9a45ae.transform, _0x655c16d2._0x8ead6ad1(new byte[9] { 236, 195, 192, 220, 202, 226, 206, 221, 196 }, 175) + _0xe50a27f1, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 56f), this._closeIcon, _0x9a8db30d.Gold);
        _0xcc9a45ae.onClick.AddListener(() => _0xbea37767.Invoke());
        return _0xb6db196c;
    }

    [SerializeField]
    private Sprite _closeIcon;
    private _0xfae56bc0 _0xd3d2faab;
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x3fa07c5c(_0xfae56bc0 _0xf580ed56, string _0x2d62ff57, Color _0x4171505b, string _0x0ad0cbaa, string _0xcf671ec8, string _0x6c42aa3e)
    {
        if (_0xf580ed56 == null)
            return;
        if (_0xf580ed56.Header != null)
        {
            _0xf580ed56.Header.text = _0x2d62ff57;
            _0xf580ed56.Header.color = _0x4171505b;
            _0x9ed53401.ApplyOutline(_0xf580ed56.Header, _0x4171505b);
        }

        if (_0xf580ed56.Main != null)
            _0xf580ed56.Main.text = _0x0ad0cbaa;
        if (_0xf580ed56.Extra != null)
            _0xf580ed56.Extra.text = _0xcf671ec8;
        if (_0xf580ed56.FirstLabel != null)
            _0xf580ed56.FirstLabel.text = _0x6c42aa3e;
    }

    private _0xfae56bc0 _0x6affe71c;
}

internal static class _0x655c16d2
{
    internal static string _0x8ead6ad1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}