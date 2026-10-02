using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

// Spawns and drives everything that travels down the road. The placement rule is the
// balance guarantee of rule C.5: a decoy crate or a hazard is NEVER put on the rail the
// cart is sitting in at the moment it appears, so a player who never touches the screen
// cannot be hit and the base run lasts its whole clock. Risk only exists for a player who
// leaves that rail to chase the wanted crate - and the row is always on the road by then,
// so crossing is a question of timing rather than of luck.
public sealed class _0x08cd28a2 : MonoBehaviour
{
    public void _0x5c850f12(Transform _0x221e3901, float[] _0xff9ad96e, float _0x5967b84c, float _0xa48ab709, float _0xbb2c313a, float _0xe7974ab6)
    {
        this._0x8b551489 = _0x221e3901;
        for (int _0xf4a03313 = 0; _0xf4a03313 < _0x6268eeb2.Lanes && _0xf4a03313 < _0xff9ad96e.Length; _0xf4a03313++)
            this._0x089be2cc[_0xf4a03313] = _0xff9ad96e[_0xf4a03313];
        this._0x2891e0c7 = _0x5967b84c;
        this._0xc3f2160d = _0xa48ab709;
        this._0x184b45c4 = _0xbb2c313a;
        this._0xa278c529 = _0xe7974ab6 * _0x6268eeb2.PickupWindowOfLane;
        this._0x8d739111 = _0xe7974ab6 * _0x6268eeb2.CrateWidthOfLane;
        this._0x9838df14 = _0xe7974ab6 * _0x6268eeb2.HazardWidthOfLane;
        this._0x254d7b27 = _0xe7974ab6 * _0x6268eeb2.BurstWidthOfLane;
    }

    private readonly List<_0xd0e60fe7> _0x1b102895 = new List<_0xd0e60fe7>();
    public int _0x6ea302ab
    {
        get
        {
            for (int _0xa3dfe4af = 0; _0xa3dfe4af < this._0x1b102895.Count; _0xa3dfe4af++)
                if (this._0x1b102895[_0xa3dfe4af].IsTarget)
                    return this._0x1b102895[_0xa3dfe4af].Lane;
            return -1;
        }
    }

    public void _0x3e477edb(float distance, int _0x6031a3ce, int _0x98301c38)
    {
        for (int _0x4f3c21bc = this._0x1b102895.Count - 1; _0x4f3c21bc >= 0; _0x4f3c21bc--)
        {
            _0xd0e60fe7 _0x18a21e34 = this._0x1b102895[_0x4f3c21bc];
            if (_0x18a21e34.Body == null)
            {
                this._0x1b102895.RemoveAt(_0x4f3c21bc);
                continue;
            }

            Vector3 _0x8c13fb5a = _0x18a21e34.Body.localPosition;
            _0x8c13fb5a.y -= distance;
            _0x18a21e34.Body.localPosition = _0x8c13fb5a;
            if (_0x18a21e34.Lane == _0x6031a3ce && Mathf.Abs(_0x8c13fb5a.y - this._0x184b45c4) < this._0xa278c529)
            {
                if (_0x18a21e34.IsHazard)
                {
                    this.Struck = this.Struck + 1;
                }
                else if (_0x18a21e34.Colour == _0x98301c38)
                {
                    this.TookCorrect = this.TookCorrect + 1;
                    this._0x33d458b5(_0x8c13fb5a);
                }
                else if (_0x18a21e34.IsTarget)
                {
                    // The queue moved on while this one was still falling, so it is no
                    // longer the crate the dispatcher wants. Not the player's mistake:
                    // it leaves the road without costing a strike.
                    this.Missed = this.Missed + 1;
                }
                else
                {
                    this.TookWrong = this.TookWrong + 1;
                }

                this._0xd92d5a32(_0x4f3c21bc, _0x18a21e34);
                continue;
            }

            if (_0x8c13fb5a.y < this._0xc3f2160d)
            {
                // A wanted crate that reaches the bottom untouched costs time and the
                // streak, never a strike - and the dispatcher simply sends the same
                // colour again, so all 28 stay reachable however many slip past.
                if (_0x18a21e34.IsTarget)
                    this.Missed = this.Missed + 1;
                this._0xd92d5a32(_0x4f3c21bc, _0x18a21e34);
            }
        }
    }

    private float _0xa278c529;
    [SerializeField]
    private GameObject _burstPrefab;
    private float _0xc3f2160d;
    [SerializeField]
    private GameObject _cratePrefab;
    // The obstacle row, dropped partway through the wanted crate's flight. It never uses
    // the cart's current rail - that is the balance guarantee of rule C.5, nothing can be
    // dropped on top of a player who is standing still - and never the wanted crate's
    // rail, so the crate always stays collectable. With three rails that leaves the player
    // exactly one clear way through, and the skill is in timing the move rather than in
    // guessing: the row is already on the road when the next crate appears, so sliding
    // across blindly is what costs a strike.
    public void _0x48ddd397(int _0x1184b8d5, bool _0x96a79c4c, bool _0x7d084849, int _0x4122f096, int _0x66617774)
    {
        if (!_0x96a79c4c && !_0x7d084849)
            return;
        int _0x791a9211 = this._0x6ea302ab;
        List<int> _0xdb0aeae3 = new List<int>();
        for (int _0x69930503 = 0; _0x69930503 < _0x6268eeb2.Lanes; _0x69930503++)
            if (_0x69930503 != _0x791a9211 && _0x69930503 != _0x4122f096)
                _0xdb0aeae3.Add(_0x69930503);
        if (_0xdb0aeae3.Count == 0)
            return;
        int step = Mathf.Abs(_0x66617774);
        int _0x05a4039b = _0xdb0aeae3[step % _0xdb0aeae3.Count];
        if (_0x7d084849)
        {
            this.Add(_0x05a4039b, step % 2, true, false);
            return;
        }

        int _0x9ade9835 = (_0x1184b8d5 + 1 + (step % 3)) % 4;
        if (_0x9ade9835 == _0x1184b8d5)
            _0x9ade9835 = (_0x1184b8d5 + 1) % 4;
        this.Add(_0x05a4039b, _0x9ade9835, false, false);
    }

    private float _0x2891e0c7;
    [SerializeField]
    private Sprite[] _hazardSprites;
    private sealed class _0xd0e60fe7
    {
        public Transform Body;
        public SpriteRenderer Skin;
        public int Lane;
        public int Colour;
        public bool IsHazard;
        public bool IsTarget;
    }

    private void _0x33d458b5(Vector3 _0x6b86c0d4)
    {
        if (this._burstPrefab == null || this._0x8b551489 == null)
            return;
        GameObject _0xd3305879 = Instantiate(this._burstPrefab, this._0x8b551489);
        _0xd3305879.transform.localPosition = _0x6b86c0d4;
        _0xd3305879.transform.localScale = Vector3.one;
        SpriteRenderer _0x27faefd1 = _0xd3305879.GetComponent<SpriteRenderer>();
        if (_0x27faefd1 != null)
        {
            _0x27faefd1.drawMode = SpriteDrawMode.Sliced;
            _0x27faefd1.size = new Vector2(this._0x254d7b27 * 0.55f, this._0x254d7b27 * 0.55f);
            _0x27faefd1.sortingOrder = _0x6268eeb2.OrderBurst;
            _0x27faefd1.color = _0x9a8db30d.Gold;
            DOTween.To(() => _0x27faefd1.size, _0x70ea79ec => _0x27faefd1.size = _0x70ea79ec, new Vector2(this._0x254d7b27, this._0x254d7b27), 0.28f).SetEase(Ease.OutQuad);
            _0x27faefd1.DOFade(0f, 0.28f);
        }

        DOVirtual.DelayedCall(0.32f, () =>
        {
            if (_0xd3305879 != null)
                Destroy(_0xd3305879);
        });
    }

    private float _0x254d7b27;
    public int Missed;
    private void _0xd92d5a32(int _0x43ba3c23, _0xd0e60fe7 _0xd2eec188)
    {
        if (_0xd2eec188.Body != null)
            Destroy(_0xd2eec188.Body.gameObject);
        this._0x1b102895.RemoveAt(_0x43ba3c23);
    }

    private Transform _0x8b551489;
    public int Struck;
    private float _0x184b45c4;
    private void Add(int _0x3bd8b410, int _0x5c45ff6f, bool _0x422c726c, bool _0x816a1237)
    {
        GameObject _0xa3536519 = _0x422c726c ? this._hazardPrefab : this._cratePrefab;
        if (_0xa3536519 == null || this._0x8b551489 == null)
            return;
        int _0xc5d127e9 = Mathf.Clamp(_0x3bd8b410, 0, _0x6268eeb2.Lanes - 1);
        GameObject _0x673386ab = Instantiate(_0xa3536519, this._0x8b551489);
        _0x673386ab.transform.localPosition = new Vector3(this._0x089be2cc[_0xc5d127e9], this._0x2891e0c7, 0f);
        _0x673386ab.transform.localScale = Vector3.one;
        _0xd0e60fe7 _0xdb93719e = new _0xd0e60fe7();
        _0xdb93719e.Body = _0x673386ab.transform;
        _0xdb93719e.Lane = _0xc5d127e9;
        _0xdb93719e.Colour = _0x5c45ff6f;
        _0xdb93719e.IsHazard = _0x422c726c;
        _0xdb93719e.IsTarget = _0x816a1237;
        _0xdb93719e.Skin = _0x673386ab.GetComponent<SpriteRenderer>();
        if (_0xdb93719e.Skin != null)
        {
            float width = _0x422c726c ? this._0x9838df14 : this._0x8d739111;
            _0xdb93719e.Skin.drawMode = SpriteDrawMode.Sliced;
            _0xdb93719e.Skin.size = new Vector2(width, width);
            _0xdb93719e.Skin.sortingOrder = _0x422c726c ? _0x6268eeb2.OrderHazard : _0x6268eeb2.OrderCrate;
            Sprite[] _0xa2acef3b = _0x422c726c ? this._hazardSprites : this._crateSprites;
            if (_0xa2acef3b != null && _0xa2acef3b.Length > 0)
            {
                Sprite _0xd7e39a8d = _0xa2acef3b[Mathf.Abs(_0x5c45ff6f) % _0xa2acef3b.Length];
                if (_0xd7e39a8d != null)
                    _0xdb93719e.Skin.sprite = _0xd7e39a8d;
            }

            _0xdb93719e.Skin.color = Color.white;
        }

        this._0x1b102895.Add(_0xdb93719e);
    }

    private float _0x8d739111;
    // The wanted crate. The director has already filtered its lane against the cart's own
    // rail, so this only has to place it.
    public void _0x9a9c134e(int _0x054d9619, int _0x3c517901)
    {
        this.Add(_0x3c517901, _0x054d9619, false, true);
    }

    // How many wanted crates are still on the road, and which lane the first of them is
    // in. The director only orders a new wanted crate when this is zero, which is what
    // keeps the three queue chips honest: the crate coming down the road is always the
    // one the chips say is next, because the queue cannot advance while it is in flight.
    public int _0x3ecacbe3
    {
        get
        {
            int _0x6b94e937 = 0;
            for (int _0xd24a5a5e = 0; _0xd24a5a5e < this._0x1b102895.Count; _0xd24a5a5e++)
                if (this._0x1b102895[_0xd24a5a5e].IsTarget)
                    _0x6b94e937++;
            return _0x6b94e937;
        }
    }

    private float[] _0x089be2cc = new float[_0x6268eeb2.Lanes];
    public void _0x8fe9bff2()
    {
        this.TookCorrect = 0;
        this.TookWrong = 0;
        this.Struck = 0;
        this.Missed = 0;
    }

    public int TookCorrect;
    [SerializeField]
    private GameObject _hazardPrefab;
    public int TookWrong;
    [SerializeField]
    private Sprite[] _crateSprites;
    private float _0x9838df14;
    public void _0xa1894841()
    {
        for (int _0xfebc593f = this._0x1b102895.Count - 1; _0xfebc593f >= 0; _0xfebc593f--)
        {
            _0xd0e60fe7 _0xd1ab2456 = this._0x1b102895[_0xfebc593f];
            if (_0xd1ab2456.Body != null)
                Destroy(_0xd1ab2456.Body.gameObject);
        }

        this._0x1b102895.Clear();
    }
}