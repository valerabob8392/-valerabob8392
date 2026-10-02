using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Everything the player sees in 1_MenuScene. The template ships DefaultPanel/Content
// empty apart from one invisible button wired to SCENE_1, so the whole menu face is
// built here and the PLAY plate is drawn as a CHILD of that button: a UGUI click on the
// child bubbles up to the ancestor Button, which keeps the template's own LoadSceneButton
// as the single driver (rule C.1) instead of a second parallel route into the game.
public sealed class _0xb9d908af : MonoBehaviour
{
    [SerializeField]
    private RectTransform _playButton;
    private GameObject _0x6fe90a93;
    [SerializeField]
    private Sprite[] _crateSprites;
    private TextMeshProUGUI _0x196cd451;
    private GameObject _0xbf5bcfbc;
    private void _0x93926c17(Transform _0x70f34732)
    {
        RectTransform _0x571c6a37 = _0x9dceb157.Fill(_0x70f34732, _0x34dd1e84._0xaeeb02a0(new byte[11] { 197, 248, 226, 227, 242, 228, 196, 255, 242, 242, 227 }, 151));
        this._0x6fe90a93 = _0x571c6a37.gameObject;
        Image _0xad091c26 = _0x9dceb157.Plate(_0x571c6a37, _0x34dd1e84._0xaeeb02a0(new byte[11] { 228, 217, 195, 194, 211, 197, 229, 213, 196, 223, 219 }, 182), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1302f, 2748f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Night, 0.92f), 3f);
        _0xad091c26.raycastTarget = true;
        _0x9ed53401.Label(_0x571c6a37, this._font, _0x34dd1e84._0xaeeb02a0(new byte[11] { 228, 217, 195, 194, 211, 197, 226, 223, 194, 218, 211 }, 182), new Vector2(0.5f, 0.9f), Vector2.zero, new Vector2(700f, 80f), 56f, _0x9a8db30d.Gold, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[6] { 49, 44, 54, 55, 38, 48 }, 99);
        Button _0x497ed197 = _0x9dceb157.Tap(_0x571c6a37, _0x34dd1e84._0xaeeb02a0(new byte[11] { 44, 17, 11, 10, 27, 13, 61, 18, 17, 13, 27 }, 126), new Vector2(0.9f, 0.9f), Vector2.zero, new Vector2(104f, 104f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 2.2f);
        _0x9dceb157.Picture(_0x497ed197.transform, _0x34dd1e84._0xaeeb02a0(new byte[15] { 133, 184, 162, 163, 178, 164, 148, 187, 184, 164, 178, 154, 182, 165, 188 }, 215), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 56f), this._closeIcon, _0x9a8db30d.Gold);
        _0x497ed197.onClick.AddListener(() => this._0x6707c9ab());
        // Card geometry, rule C.25: the badge gutter and the text column never share an
        // x band. Gutter centre 92, width 64 -> text column starts at 170 and is 760 wide,
        // so the nearest text edge sits 46 px clear of the badge.
        for (int _0x47b8c5d6 = 0; _0x47b8c5d6 < 3; _0x47b8c5d6++)
        {
            float _0x87546838 = 0.72f - (_0x47b8c5d6 * 0.22f);
            Image _0x9c126204 = _0x9dceb157.Plate(_0x571c6a37, _0x34dd1e84._0xaeeb02a0(new byte[9] { 111, 82, 72, 73, 88, 126, 92, 79, 89 }, 61) + _0x47b8c5d6.ToString(), new Vector2(0.5f, _0x87546838), Vector2.zero, new Vector2(1040f, 300f), this._plateSprite, _0x9a8db30d.Steel, 3.4f);
            _0x9c126204.raycastTarget = true;
            this._0xae49da57[_0x47b8c5d6] = _0x9c126204;
            Image _0x83949fed = _0x9dceb157.Plate(_0x9c126204.transform, _0x34dd1e84._0xaeeb02a0(new byte[14] { 223, 226, 248, 249, 232, 206, 236, 255, 233, 196, 227, 227, 232, 255 }, 141) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1028f, 288f), this._plateSprite, _0x9a8db30d.Panel, 3.4f);
            Image _0x8329954d = _0x9dceb157.Plate(_0x83949fed.transform, _0x34dd1e84._0xaeeb02a0(new byte[10] { 238, 211, 201, 200, 217, 254, 221, 216, 219, 217 }, 188) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(-428f, 0f), new Vector2(64f, 64f), this._plateSprite, _0x9a8db30d.Gold, 2.2f);
            this._0x54ca96c2[_0x47b8c5d6] = _0x9ed53401.Label(_0x8329954d.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[15] { 111, 82, 72, 73, 88, 127, 92, 89, 90, 88, 107, 92, 81, 72, 88 }, 61) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(56f, 56f), 36f, _0x9a8db30d.Ink, TextAlignmentOptions.Center);
            this._0x54ca96c2[_0x47b8c5d6].text = (_0x47b8c5d6 + 1).ToString();
            _0x9ed53401.Label(_0x83949fed.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 31, 34, 56, 57, 40, 3, 44, 32, 40 }, 77) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(30f, 92f), new Vector2(760f, 56f), 46f, _0x9a8db30d.Gold, TextAlignmentOptions.Left).text = _0x6268eeb2.RouteTitle[_0x47b8c5d6];
            _0x9ed53401.Label(_0x83949fed.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 121, 68, 94, 95, 78, 120, 91, 78, 72 }, 43) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(30f, 30f), new Vector2(760f, 44f), 32f, _0x9a8db30d.Cream, TextAlignmentOptions.Left).text = _0x34dd1e84._0xaeeb02a0(new byte[26] { 191, 182, 189, 180, 167, 187, 211, 193, 203, 211, 176, 161, 178, 167, 182, 160, 211, 222, 211, 160, 163, 182, 182, 183, 211, 139 }, 243) + _0x6268eeb2.RouteSpeedMultiplier[_0x47b8c5d6].ToString(_0x34dd1e84._0xaeeb02a0(new byte[4] { 214, 200, 214, 214 }, 230));
            this._0xc4b9a868[_0x47b8c5d6] = _0x9dceb157.Strip(_0x83949fed.transform, _0x34dd1e84._0xaeeb02a0(new byte[8] { 158, 163, 185, 184, 169, 142, 173, 190 }, 204) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(30f, -24f), new Vector2(760f, 20f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.9f), _0x9a8db30d.Teal);
            this._0x137c53cc[_0x47b8c5d6] = _0x9ed53401.Label(_0x83949fed.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 88, 101, 127, 126, 111, 72, 111, 121, 126 }, 10) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), new Vector2(30f, -86f), new Vector2(760f, 44f), 32f, _0x9a8db30d.Sand, TextAlignmentOptions.Left);
            this._0x28e92e9d[_0x47b8c5d6] = _0x9dceb157.Picture(_0x8329954d.transform, _0x34dd1e84._0xaeeb02a0(new byte[9] { 146, 175, 181, 180, 165, 140, 175, 163, 171 }, 192) + _0x47b8c5d6.ToString(), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(48f, 48f), this._lockIcon, _0x9a8db30d.Ink);
            this._0x28e92e9d[_0x47b8c5d6].enabled = false;
            Button _0x93a41796 = _0x9c126204.gameObject.AddComponent<Button>();
            _0x93a41796.targetGraphic = _0x83949fed;
            int _0xf9dc90ab = _0x47b8c5d6;
            _0x93a41796.onClick.AddListener(() => this._0xac5640e2(_0xf9dc90ab));
        }

        this._0x6fe90a93.SetActive(false);
    }

    [SerializeField]
    private Sprite _tutQueue;
    [SerializeField]
    private Sprite _tutStrikes;
    private int _0x160076fd;
    [SerializeField]
    private Sprite _cartSprite;
    // Splash loading bar (rule G): the template ships it white fill on a white track at
    // alpha 1/255, i.e. invisible. The fill takes the route accent and the track the
    // darkest palette tone at full alpha, so progress reads on the splash screenshot.
    private void _0xff941f43()
    {
        _0x5d442966 _0x936f75e7 = _0x5d442966.Instance;
        if (_0x936f75e7 == null)
            return;
        Slider _0xd5744225 = _0x936f75e7.AnimationSlider;
        if (_0xd5744225 == null)
            _0xd5744225 = _0x936f75e7.GetComponentInChildren<Slider>(true);
        if (_0xd5744225 == null)
            return;
        RectTransform _0x01243df2 = _0xd5744225.fillRect;
        if (_0x01243df2 == null)
            return;
        Image _0x6b41d25d = _0x01243df2.GetComponent<Image>();
        if (_0x6b41d25d != null)
            _0x6b41d25d.color = _0x9a8db30d.Gold;
        Transform _0x5b855eb2 = _0x01243df2.parent;
        if (_0x5b855eb2 == null)
            return;
        Image _0x5aebced7 = _0x5b855eb2.GetComponent<Image>();
        if (_0x5aebced7 != null)
            _0x5aebced7.color = _0x9a8db30d.Ink;
        this.DressSplash(_0x936f75e7, _0xd5744225.transform);
    }

    private Image[] _0xae49da57 = new Image[3];
    private void _0xefefe036()
    {
        int _0xcd1d0329 = _0xdb1b25f0._0x03c4ad88;
        if (this._0x196cd451 != null)
            this._0x196cd451.text = _0x34dd1e84._0xaeeb02a0(new byte[6] { 242, 239, 245, 244, 229, 128 }, 160) + (this._0x160076fd + 1).ToString() + _0x34dd1e84._0xaeeb02a0(new byte[3] { 117, 120, 117 }, 85) + _0x6268eeb2.RouteTitle[this._0x160076fd];
        if (this._0x32c43de5 != null)
            this._0x32c43de5.text = _0x9ed53401.Pair(_0x34dd1e84._0xaeeb02a0(new byte[4] { 74, 77, 91, 92 }, 8), _0xdb1b25f0.Best(this._0x160076fd), _0x6268eeb2.CratesPerRoute);
        Color _0x3d7c6e85 = _0x9a8db30d.Crate(this._0x160076fd);
        for (int _0x68d18c28 = 0; _0x68d18c28 < this._0xce176edb.Length; _0x68d18c28++)
            if (this._0xce176edb[_0x68d18c28] != null)
                this._0xce176edb[_0x68d18c28].color = _0x3d7c6e85;
        for (int _0x84ba7ed1 = 0; _0x84ba7ed1 < this._0xae49da57.Length; _0x84ba7ed1++)
        {
            bool _0x877f188d = _0x84ba7ed1 >= _0xcd1d0329;
            if (this._0xae49da57[_0x84ba7ed1] != null)
                this._0xae49da57[_0x84ba7ed1].color = _0x84ba7ed1 == this._0x160076fd ? _0x9a8db30d.Gold : _0x9a8db30d.Alpha(_0x9a8db30d.Steel, _0x877f188d ? 0.55f : 1f);
            if (this._0xc4b9a868[_0x84ba7ed1] != null)
                _0x9dceb157.SetBar(this._0xc4b9a868[_0x84ba7ed1], _0x877f188d ? 0f : (float)_0xdb1b25f0.Best(_0x84ba7ed1) / _0x6268eeb2.CratesPerRoute, 760f);
            if (this._0x137c53cc[_0x84ba7ed1] != null)
                this._0x137c53cc[_0x84ba7ed1].text = _0x877f188d ? _0x34dd1e84._0xaeeb02a0(new byte[25] { 102, 105, 110, 105, 115, 104, 0, 116, 104, 101, 0, 112, 114, 101, 118, 105, 111, 117, 115, 0, 114, 111, 117, 116, 101 }, 32) : _0x9ed53401.Pair(_0x34dd1e84._0xaeeb02a0(new byte[4] { 86, 81, 71, 64 }, 20), _0xdb1b25f0.Best(_0x84ba7ed1), _0x6268eeb2.CratesPerRoute);
            if (this._0x28e92e9d[_0x84ba7ed1] != null)
                this._0x28e92e9d[_0x84ba7ed1].enabled = _0x877f188d && this._0x28e92e9d[_0x84ba7ed1].sprite != null;
            if (this._0x54ca96c2[_0x84ba7ed1] != null)
                this._0x54ca96c2[_0x84ba7ed1].enabled = !_0x877f188d;
        }
    }

    private TextMeshProUGUI _0x32c43de5;
    private void _0x8077e043()
    {
        if (this._0xbf5bcfbc != null)
            this._0xbf5bcfbc.SetActive(true);
    }

    [SerializeField]
    private Sprite _plateSprite;
    private TextMeshProUGUI _0xe530c9a6;
    private Image[] _0xc4b9a868 = new Image[3];
    private TextMeshProUGUI[] _0x137c53cc = new TextMeshProUGUI[3];
    [SerializeField]
    private Sprite _markSprite;
    [SerializeField]
    private TMP_FontAsset _font;
    // The inherited tutorial pages ship with filler copy. They are switched off for this
    // game, but any page that could ever surface is rewritten to this game's controls so
    // no placeholder wording can reach a screen (rule C.15).
    private void _0xa7090e59()
    {
        _0x57de1605 _0x122dbb79 = _0x57de1605.Instance;
        if (_0x122dbb79 == null || _0x122dbb79.Panels == null)
            return;
        int[] _0x63f512c0 =
        {
            _0xb7a79f4e._0x4a0666d8.TUTORIAL0,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL1,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL2,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL3,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL4,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL5,
            _0xb7a79f4e._0x4a0666d8.TUTORIAL6,
        };
        string[] _0xa0d903e7 =
        {
            _0x34dd1e84._0xaeeb02a0(new byte[11] { 0, 11, 2, 13, 4, 6, 99, 15, 2, 13, 6 }, 67),
            _0x34dd1e84._0xaeeb02a0(new byte[16] { 240, 249, 250, 250, 249, 225, 150, 226, 254, 243, 150, 249, 228, 242, 243, 228 }, 182),
            _0x34dd1e84._0xaeeb02a0(new byte[13] { 85, 73, 83, 68, 68, 33, 82, 85, 83, 72, 74, 68, 82 }, 1),
            _0x34dd1e84._0xaeeb02a0(new byte[11] { 200, 195, 202, 197, 204, 206, 171, 199, 202, 197, 206 }, 139),
            _0x34dd1e84._0xaeeb02a0(new byte[16] { 174, 167, 164, 164, 167, 191, 200, 188, 160, 173, 200, 167, 186, 172, 173, 186 }, 232),
            _0x34dd1e84._0xaeeb02a0(new byte[13] { 39, 59, 33, 54, 54, 83, 32, 39, 33, 58, 56, 54, 32 }, 115),
            _0x34dd1e84._0xaeeb02a0(new byte[11] { 31, 20, 29, 18, 27, 25, 124, 16, 29, 18, 25 }, 92)
        };
        string[] _0xa91a6214 =
        {
            _0x34dd1e84._0xaeeb02a0(new byte[42] { 253, 249, 231, 254, 235, 142, 225, 252, 142, 250, 239, 254, 142, 226, 235, 232, 250, 142, 129, 142, 252, 231, 233, 230, 250, 164, 250, 225, 142, 227, 225, 248, 235, 142, 250, 230, 235, 142, 237, 239, 252, 250 }, 174),
            _0x34dd1e84._0xaeeb02a0(new byte[44] { 11, 30, 13, 14, 108, 3, 2, 0, 21, 108, 24, 4, 9, 108, 15, 30, 13, 24, 9, 70, 31, 4, 3, 27, 2, 108, 10, 5, 30, 31, 24, 108, 5, 2, 108, 24, 4, 9, 108, 29, 25, 9, 25, 9 }, 76),
            _0x34dd1e84._0xaeeb02a0(new byte[39] { 154, 137, 254, 251, 230, 231, 238, 137, 234, 251, 232, 253, 236, 250, 137, 230, 251, 137, 234, 251, 232, 250, 225, 236, 250, 163, 236, 231, 237, 137, 253, 225, 236, 137, 251, 230, 252, 253, 236 }, 169),
            _0x34dd1e84._0xaeeb02a0(new byte[42] { 179, 183, 169, 176, 165, 192, 175, 178, 192, 180, 161, 176, 192, 172, 165, 166, 180, 192, 207, 192, 178, 169, 167, 168, 180, 234, 180, 175, 192, 173, 175, 182, 165, 192, 180, 168, 165, 192, 163, 161, 178, 180 }, 224),
            _0x34dd1e84._0xaeeb02a0(new byte[44] { 167, 178, 161, 162, 192, 175, 174, 172, 185, 192, 180, 168, 165, 192, 163, 178, 161, 180, 165, 234, 179, 168, 175, 183, 174, 192, 166, 169, 178, 179, 180, 192, 169, 174, 192, 180, 168, 165, 192, 177, 181, 165, 181, 165 }, 224),
            _0x34dd1e84._0xaeeb02a0(new byte[39] { 121, 106, 29, 24, 5, 4, 13, 106, 9, 24, 11, 30, 15, 25, 106, 5, 24, 106, 9, 24, 11, 25, 2, 15, 25, 64, 15, 4, 14, 106, 30, 2, 15, 106, 24, 5, 31, 30, 15 }, 74),
            _0x34dd1e84._0xaeeb02a0(new byte[42] { 90, 94, 64, 89, 76, 41, 70, 91, 41, 93, 72, 89, 41, 69, 76, 79, 93, 41, 38, 41, 91, 64, 78, 65, 93, 3, 93, 70, 41, 68, 70, 95, 76, 41, 93, 65, 76, 41, 74, 72, 91, 93 }, 9),
        };
        for (int _0x9c2d49f7 = 0; _0x9c2d49f7 < _0x63f512c0.Length; _0x9c2d49f7++)
        {
            int _0xa7372c71 = _0x63f512c0[_0x9c2d49f7];
            if (_0xa7372c71 < 0 || _0xa7372c71 >= _0x122dbb79.Panels.Count)
                continue;
            _0x3dafaafe _0x59999638 = _0x122dbb79.Panels[_0xa7372c71];
            if (_0x59999638 == null || _0x59999638.Content == null)
                continue;
            TMP_Text[] _0xd5eb46ce = _0x59999638.Content.GetComponentsInChildren<TMP_Text>(true);
            for (int _0xb56f975a = 0; _0xb56f975a < _0xd5eb46ce.Length; _0xb56f975a++)
            {
                bool _0xb182a0f8 = _0xb56f975a == 0;
                _0x9ed53401.Dress(_0xd5eb46ce[_0xb56f975a], _0xb182a0f8 ? _0xa0d903e7[_0x9c2d49f7] : _0xa91a6214[_0x9c2d49f7], _0xb182a0f8 ? 52f : 38f, _0xb182a0f8 ? _0x9a8db30d.Gold : _0x9a8db30d.Cream);
            }
        }
    }

    private void _0xac5640e2(int _0x48ee95c5)
    {
        int _0xcdcf0a21 = _0x6268eeb2.ClampRoute(_0x48ee95c5);
        if (_0xcdcf0a21 >= _0xdb1b25f0._0x03c4ad88)
            return;
        this._0x160076fd = _0xcdcf0a21;
        _0xdb1b25f0._0xbb95ef03 = _0xcdcf0a21;
        this._0xefefe036();
        Image _0x813a39cd = this._0xae49da57[_0xcdcf0a21];
        if (_0x813a39cd != null)
        {
            Transform _0x826aed02 = _0x813a39cd.transform;
            DOTween.Kill(_0x826aed02, true);
            _0x826aed02.localScale = Vector3.one;
            _0x826aed02.DOPunchScale(Vector3.one * 0.04f, 0.32f, 6, 0.6f);
        }
    }

    private void Start()
    {
        Transform _0x02d5ba1a = this._0xc9f6325e();
        if (_0x02d5ba1a == null)
            return;
        this._0x160076fd = _0x6268eeb2.ClampRoute(_0xdb1b25f0._0xbb95ef03);
        RectTransform _0x564fc5fb = _0x9dceb157.Fill(_0x02d5ba1a, _0x34dd1e84._0xaeeb02a0(new byte[8] { 40, 0, 11, 16, 35, 4, 6, 0 }, 101));
        _0x564fc5fb.SetAsFirstSibling();
        // Lifetime delivery count. The menu template carries no CoinsContainer, so the
        // counter is built here straight from the value the template already stores.
        Image _0x9d440301 = _0x9dceb157.Plate(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[10] { 7, 55, 59, 38, 49, 4, 56, 53, 32, 49 }, 84), new Vector2(0.5f, 0.955f), Vector2.zero, new Vector2(400f, 104f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Ink, 0.8f), 3.4f);
        _0x9dceb157.Picture(_0x9d440301.transform, _0x34dd1e84._0xaeeb02a0(new byte[9] { 13, 61, 49, 44, 59, 19, 63, 44, 53 }, 94), new Vector2(0f, 0.5f), new Vector2(66f, 0f), new Vector2(64f, 64f), this._markSprite, _0x9a8db30d.Gold);
        this._0xe530c9a6 = _0x9ed53401.Label(_0x9d440301.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[10] { 228, 212, 216, 197, 210, 225, 214, 219, 194, 210 }, 183), new Vector2(0.5f, 0.5f), new Vector2(34f, 0f), new Vector2(250f, 72f), 48f, _0x9a8db30d.Cream, TextAlignmentOptions.Left);
        this._0xe530c9a6.text = _0xdb1b25f0._0x8da23d77.ToString();
        Image _0x56fc18b1 = _0x9dceb157.Picture(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[8] { 38, 11, 28, 1, 45, 15, 28, 26 }, 110), new Vector2(0.5f, 0.715f), Vector2.zero, new Vector2(820f, 820f), this._cartSprite, Color.white);
        RectTransform _0xd5d3cfdf = _0x56fc18b1.rectTransform;
        Vector2 _0x6d1d5f80 = _0xd5d3cfdf.anchoredPosition;
        _0xd5d3cfdf.anchoredPosition = _0x6d1d5f80 + new Vector2(0f, 40f);
        _0xd5d3cfdf.DOAnchorPos(_0x6d1d5f80, 0.36f).SetEase(Ease.OutCubic);
        // Three blocks in the colours of the chosen route - the preview repaints when a
        // route is picked, which is one of the three visible confirmations (rule C.7).
        for (int _0x4eacdf96 = 0; _0x4eacdf96 < 3; _0x4eacdf96++)
        {
            float _0xc6ad5f27 = -258f + (_0x4eacdf96 * 258f);
            this._0xce176edb[_0x4eacdf96] = _0x9dceb157.Plate(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[12] { 236, 206, 217, 202, 213, 217, 203, 254, 208, 211, 223, 215 }, 188) + _0x4eacdf96.ToString(), new Vector2(0.5f, 0.545f), new Vector2(_0xc6ad5f27, 0f), new Vector2(240f, 26f), this._plateSprite, _0x9a8db30d.Gold, 6f);
        }

        _0x9ed53401.Label(_0x564fc5fb, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 194, 239, 231, 232, 238, 249, 228, 251, 232 }, 141), new Vector2(0.5f, 0.485f), Vector2.zero, new Vector2(1040f, 64f), 46f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[26] { 124, 125, 116, 113, 110, 125, 106, 24, 10, 0, 24, 123, 106, 121, 108, 125, 107, 24, 113, 118, 24, 119, 106, 124, 125, 106 }, 56);
        this._0x196cd451 = _0x9ed53401.Label(_0x564fc5fb, this._font, _0x34dd1e84._0xaeeb02a0(new byte[10] { 183, 138, 144, 145, 128, 169, 132, 135, 128, 137 }, 229), new Vector2(0.5f, 0.43f), Vector2.zero, new Vector2(1040f, 52f), 38f, _0x9a8db30d.Gold, TextAlignmentOptions.Center);
        Image _0x5ea01584 = _0x9dceb157.Plate(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[9] { 250, 221, 203, 204, 232, 212, 217, 204, 221 }, 184), new Vector2(0.5f, 0.372f), Vector2.zero, new Vector2(560f, 76f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Panel, 0.92f), 3.4f);
        this._0x32c43de5 = _0x9ed53401.Label(_0x5ea01584.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 243, 212, 194, 197, 231, 208, 221, 196, 212 }, 177), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(520f, 60f), 40f, _0x9a8db30d.Teal, TextAlignmentOptions.Center);
        this._0x5210da40();
        Button _0x9d8ccb6f = _0x9dceb157.Tap(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[9] { 115, 78, 84, 85, 68, 82, 117, 64, 81 }, 33), new Vector2(0.5f, 0.158f), Vector2.zero, new Vector2(560f, 124f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.Panel, 3.4f);
        _0x9ed53401.Label(_0x9d8ccb6f.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[11] { 61, 0, 26, 27, 10, 28, 35, 14, 13, 10, 3 }, 111), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(470f, 70f), 48f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[6] { 123, 102, 124, 125, 108, 122 }, 41);
        _0x9d8ccb6f.onClick.AddListener(() => this._0x72bbf334());
        Button _0x881d79c8 = _0x9dceb157.Tap(_0x564fc5fb, _0x34dd1e84._0xaeeb02a0(new byte[8] { 18, 32, 60, 49, 48, 1, 52, 37 }, 85), new Vector2(0.5f, 0.082f), Vector2.zero, new Vector2(560f, 116f), this._plateSprite, _0x9a8db30d.Sand, _0x9a8db30d.Steel, 3.4f);
        _0x9ed53401.Label(_0x881d79c8.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[10] { 132, 182, 170, 167, 166, 143, 162, 161, 166, 175 }, 195), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(470f, 64f), 44f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[11] { 127, 120, 96, 23, 99, 120, 23, 103, 123, 118, 110 }, 55);
        _0x881d79c8.onClick.AddListener(() => this._0x8077e043());
        this._0x93926c17(_0x02d5ba1a);
        this._0x00926363(_0x02d5ba1a);
        this._0xefefe036();
        this._0xa7090e59();
        this._0xff941f43();
    }

    private void _0x00926363(Transform _0x415c049d)
    {
        RectTransform _0x1e2c25ea = _0x9dceb157.Fill(_0x415c049d, _0x34dd1e84._0xaeeb02a0(new byte[10] { 189, 143, 147, 158, 159, 169, 146, 159, 159, 142 }, 250));
        this._0xbf5bcfbc = _0x1e2c25ea.gameObject;
        Image _0x3edabaf1 = _0x9dceb157.Plate(_0x1e2c25ea, _0x34dd1e84._0xaeeb02a0(new byte[10] { 2, 48, 44, 33, 32, 22, 38, 55, 44, 40 }, 69), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1302f, 2748f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Night, 0.94f), 3f);
        _0x3edabaf1.raycastTarget = true;
        _0x9ed53401.Label(_0x1e2c25ea, this._font, _0x34dd1e84._0xaeeb02a0(new byte[10] { 195, 241, 237, 224, 225, 208, 237, 240, 232, 225 }, 132), new Vector2(0.5f, 0.9f), Vector2.zero, new Vector2(900f, 80f), 56f, _0x9a8db30d.Gold, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[11] { 59, 60, 36, 83, 39, 60, 83, 35, 63, 50, 42 }, 115);
        string[] _0x30225b2f =
        {
            _0x34dd1e84._0xaeeb02a0(new byte[42] { 173, 169, 183, 174, 187, 222, 177, 172, 222, 170, 191, 174, 222, 178, 187, 184, 170, 222, 209, 222, 172, 183, 185, 182, 170, 244, 170, 177, 222, 179, 177, 168, 187, 222, 170, 182, 187, 222, 189, 191, 172, 170 }, 254),
            _0x34dd1e84._0xaeeb02a0(new byte[44] { 36, 49, 34, 33, 67, 44, 45, 47, 58, 67, 55, 43, 38, 67, 32, 49, 34, 55, 38, 105, 48, 43, 44, 52, 45, 67, 37, 42, 49, 48, 55, 67, 42, 45, 67, 55, 43, 38, 67, 50, 54, 38, 54, 38 }, 99),
            _0x34dd1e84._0xaeeb02a0(new byte[39] { 193, 210, 165, 160, 189, 188, 181, 210, 177, 160, 179, 166, 183, 161, 210, 189, 160, 210, 177, 160, 179, 161, 186, 183, 161, 248, 183, 188, 182, 210, 166, 186, 183, 210, 160, 189, 167, 166, 183 }, 242),
        };
        Sprite[] _0x7199c705 =
        {
            this._tutLanes,
            this._tutQueue,
            this._tutStrikes
        };
        for (int _0x99557834 = 0; _0x99557834 < 3; _0x99557834++)
        {
            float _0xc892f623 = 0.72f - (_0x99557834 * 0.19f);
            Image _0xbd39b02f = _0x9dceb157.Plate(_0x1e2c25ea, _0x34dd1e84._0xaeeb02a0(new byte[8] { 169, 155, 135, 138, 139, 188, 129, 153 }, 238) + _0x99557834.ToString(), new Vector2(0.5f, _0xc892f623), Vector2.zero, new Vector2(1040f, 260f), this._plateSprite, _0x9a8db30d.Panel, 3.4f);
            _0x9dceb157.Picture(_0xbd39b02f.transform, _0x34dd1e84._0xaeeb02a0(new byte[8] { 142, 188, 160, 173, 172, 136, 187, 189 }, 201) + _0x99557834.ToString(), new Vector2(0f, 0.5f), new Vector2(150f, 0f), new Vector2(200f, 200f), _0x7199c705[_0x99557834], Color.white);
            _0x9ed53401.Label(_0xbd39b02f.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 117, 71, 91, 86, 87, 102, 87, 74, 70 }, 50) + _0x99557834.ToString(), new Vector2(0.5f, 0.5f), new Vector2(140f, 0f), new Vector2(680f, 160f), 38f, _0x9a8db30d.Cream, TextAlignmentOptions.Left).text = _0x30225b2f[_0x99557834];
        }

        Button _0x5efb5d86 = _0x9dceb157.Tap(_0x1e2c25ea, _0x34dd1e84._0xaeeb02a0(new byte[9] { 72, 122, 102, 107, 106, 75, 96, 97, 106 }, 15), new Vector2(0.5f, 0.12f), Vector2.zero, new Vector2(560f, 124f), this._plateSprite, _0x9a8db30d.Gold, _0x9a8db30d.GoldDeep, 3.4f);
        _0x9ed53401.Label(_0x5efb5d86.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[14] { 168, 154, 134, 139, 138, 171, 128, 129, 138, 163, 142, 141, 138, 131 }, 239), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(470f, 70f), 48f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[6] { 229, 237, 246, 130, 235, 246 }, 162);
        _0x5efb5d86.onClick.AddListener(() => this._0x1fa42288());
        this._0xbf5bcfbc.SetActive(false);
    }

    private void _0x5210da40()
    {
        if (this._playButton == null)
            return;
        Image _0x6432d198 = _0x9dceb157.Plate(this._playButton, _0x34dd1e84._0xaeeb02a0(new byte[8] { 25, 37, 40, 48, 15, 40, 42, 44 }, 73), new Vector2(0.5f, 0.5f), Vector2.zero, this._playButton.sizeDelta, this._plateSprite, _0x9a8db30d.Gold, 3.4f);
        _0x6432d198.raycastTarget = true;
        Image _0xffca074a = _0x9dceb157.Plate(_0x6432d198.transform, _0x34dd1e84._0xaeeb02a0(new byte[13] { 68, 120, 117, 109, 82, 117, 119, 113, 93, 122, 122, 113, 102 }, 20), new Vector2(0.5f, 0.5f), Vector2.zero, this._playButton.sizeDelta - new Vector2(12f, 12f), this._plateSprite, _0x9a8db30d.GoldDeep, 3.4f);
        _0xffca074a.raycastTarget = true;
        _0x9ed53401.Label(_0x6432d198.transform, this._font, _0x34dd1e84._0xaeeb02a0(new byte[9] { 205, 241, 252, 228, 209, 252, 255, 248, 241 }, 157), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(620f, 100f), 72f, _0x9a8db30d.Cream, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[4] { 148, 136, 133, 157 }, 196);
        Transform _0xa4067e95 = _0x6432d198.transform;
        _0xa4067e95.localScale = Vector3.one * 0.9f;
        _0xa4067e95.DOScale(1f, 0.3f).SetEase(Ease.OutBack).OnComplete(() => this._0xac59d2f8(_0xa4067e95));
    }

    private void _0x6707c9ab()
    {
        if (this._0x6fe90a93 != null)
            this._0x6fe90a93.SetActive(false);
    }

    private Transform _0xc9f6325e()
    {
        _0x57de1605 _0x24a96ece = _0x57de1605.Instance;
        if (_0x24a96ece == null || _0x24a96ece.Panels == null)
            return null;
        int _0x4f57f128 = _0xb7a79f4e._0x4a0666d8.DEFAULT;
        if (_0x4f57f128 < 0 || _0x4f57f128 >= _0x24a96ece.Panels.Count)
            return null;
        _0x3dafaafe _0xd8817a88 = _0x24a96ece.Panels[_0x4f57f128];
        if (_0xd8817a88 == null || _0xd8817a88.Content == null)
            return null;
        return _0xd8817a88.Content.transform;
    }

    private Image[] _0xce176edb = new Image[3];
    [SerializeField]
    private Sprite _closeIcon;
    private TextMeshProUGUI[] _0x54ca96c2 = new TextMeshProUGUI[3];
    // Splash face. The splash has to read as a DIFFERENT frame from the menu, so it gets
    // a dark overlay the menu does not have, an abstract gold badge and a LOADING caption
    // - and no game name anywhere, in text or in art. The splash body ships with exactly
    // one child, the loading bar, so everything added here would cover it; the bar is
    // pushed back to the front of the draw order afterwards (rule C.13).
    private void DressSplash(_0x5d442966 _0x6dea79a5, Transform _0xed25b635)
    {
        GameObject _0x938247ae = _0x6dea79a5.Content;
        if (_0x938247ae == null)
            return;
        Transform _0xf993adf2 = _0x938247ae.transform;
        Image _0x664ad516 = _0x9dceb157.Plate(_0xf993adf2, _0x34dd1e84._0xaeeb02a0(new byte[11] { 240, 211, 207, 194, 208, 203, 240, 203, 194, 199, 198 }, 163), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1302f, 2748f), this._plateSprite, _0x9a8db30d.Alpha(_0x9a8db30d.Night, 0.82f), 3f);
        _0x664ad516.raycastTarget = false;
        Image _0xbc104f08 = _0x9dceb157.Picture(_0xf993adf2, _0x34dd1e84._0xaeeb02a0(new byte[10] { 62, 29, 1, 12, 30, 5, 32, 12, 31, 6 }, 109), new Vector2(0.5f, 0.56f), Vector2.zero, new Vector2(420f, 420f), this._markSprite, _0x9a8db30d.Gold);
        Transform _0x01b3d6e9 = _0xbc104f08.transform;
        _0x01b3d6e9.localScale = Vector3.one * 0.86f;
        _0x01b3d6e9.DOScale(1f, 0.42f).SetEase(Ease.OutBack);
        _0x9ed53401.Label(_0xf993adf2, this._font, _0x34dd1e84._0xaeeb02a0(new byte[13] { 17, 50, 46, 35, 49, 42, 1, 35, 50, 54, 43, 45, 44 }, 66), new Vector2(0.5f, 0.17f), Vector2.zero, new Vector2(700f, 60f), 36f, _0x9a8db30d.Sand, TextAlignmentOptions.Center).text = _0x34dd1e84._0xaeeb02a0(new byte[7] { 209, 210, 220, 217, 212, 211, 218 }, 157);
        // Walk up from the slider to the child that sits directly in the body, so the whole
        // bar is raised - reordering the Slider alone would only move it inside its own host.
        Transform _0xea47a149 = _0xed25b635;
        while (_0xea47a149 != null && _0xea47a149.parent != _0xf993adf2)
            _0xea47a149 = _0xea47a149.parent;
        if (_0xea47a149 != null)
            _0xea47a149.SetAsLastSibling();
    }

    private void _0x1fa42288()
    {
        if (this._0xbf5bcfbc != null)
            this._0xbf5bcfbc.SetActive(false);
    }

    private Image[] _0x28e92e9d = new Image[3];
    private void _0x72bbf334()
    {
        if (this._0x6fe90a93 != null)
            this._0x6fe90a93.SetActive(true);
    }

    [SerializeField]
    private Sprite _tutLanes;
    [SerializeField]
    private Sprite _lockIcon;
    private void _0xac59d2f8(Transform _0x31f12da0)
    {
        if (_0x31f12da0 == null)
            return;
        // A finite pulse, not a perpetual loop: a tween that never settles keeps the
        // window permanently dirty, which is what stalls automated capture.
        _0x31f12da0.DOScale(1.035f, 0.9f).SetEase(Ease.InOutSine).SetLoops(12, LoopType.Yoyo);
    }
}

internal static class _0x34dd1e84
{
    internal static string _0xaeeb02a0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}