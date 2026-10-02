using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using ETouch = UnityEngine.InputSystem.EnhancedTouch.Touch;

// The cart and the two equivalent ways to drive it: a horizontal swipe across the play
// area, or a single tap on the left / right third of the screen. The tap form exists
// because the review capture can only tap - without it the album would never show a
// lane change (rule C.6 / F.0b). Taps that land in the top strip belong to the HUD
// buttons and are ignored here.
public sealed class _0xf2bb88a2 : MonoBehaviour
{
    private float _0x67c41c2f;
    private int _0xf6a6d7d6 = 1;
    public void _0x4e874412()
    {
        if (this._0xc7da3a03 == null)
            return;
        this._0xc7da3a03.DOShakePosition(0.35f, new Vector3(0.14f, 0.05f, 0f), 18, 70f, false, false);
    }

    private float _0x720fb251;
    [SerializeField]
    private GameObject _cartPrefab;
    public void _0xa9403bdc(int _0xd17fcf34)
    {
        int _0xb290106b = Mathf.Clamp(_0xd17fcf34, 0, _0x6268eeb2.Lanes - 1);
        if (_0xb290106b == this._0xf6a6d7d6 || this._0x405b5820 || this._0xc7da3a03 == null)
            return;
        float _0x54cbc06c = _0xb290106b > this._0xf6a6d7d6 ? -7f : 7f;
        this._0xf6a6d7d6 = _0xb290106b;
        this._0x405b5820 = true;
        DOTween.Kill(this._0xc7da3a03, true);
        this._0xc7da3a03.DOLocalMoveX(this._0x6bda5730[_0xb290106b], _0x6268eeb2.LaneShiftTime).SetEase(Ease.OutQuad).OnComplete(() => this._0x9d091bf4());
        this._0xc7da3a03.DOLocalRotate(new Vector3(0f, 0f, _0x54cbc06c), _0x6268eeb2.LaneShiftTime * 0.5f).SetLoops(2, LoopType.Yoyo);
    }

    private SpriteRenderer _0x41d84545;
    public Transform _0x018380f3
    {
        get
        {
            return this._0xc7da3a03;
        }
    }

    // Returns the lane the player asked for this frame, or the current lane when the
    // player did nothing. The caller decides whether the game is accepting input.
    public int _0x2ca96daa()
    {
        int _0x4d51137d = this._0xc2598c98();
        if (_0x4d51137d == 0)
            _0x4d51137d = this._0x3deb7c3c();
        if (_0x4d51137d == 0 || this._0x405b5820)
            return this._0xf6a6d7d6;
        int _0x03812026 = Mathf.Clamp(this._0xf6a6d7d6 + _0x4d51137d, 0, _0x6268eeb2.Lanes - 1);
        return _0x03812026;
    }

    private bool _0x0a0ac93d;
    private void _0x9d091bf4()
    {
        this._0x405b5820 = false;
        if (this._0xc7da3a03 != null)
            this._0xc7da3a03.localRotation = Quaternion.identity;
    }

    public float _0x5b77647d
    {
        get
        {
            return this._0xffd258e5;
        }
    }

    private float _0xffd258e5;
    public void _0x1570d471(Transform _0xf2f88939, float[] _0x2fe84ead, float _0x15963b9c, float _0x89ef8149)
    {
        EnhancedTouchSupport.Enable();
        for (int _0xec601ef0 = 0; _0xec601ef0 < _0x6268eeb2.Lanes && _0xec601ef0 < _0x2fe84ead.Length; _0xec601ef0++)
            this._0x6bda5730[_0xec601ef0] = _0x2fe84ead[_0xec601ef0];
        this._0xffd258e5 = _0x15963b9c;
        this._0xf6a6d7d6 = 1;
        this._0x720fb251 = Screen.width * 0.06f;
        this._0x67c41c2f = Screen.height * 0.88f;
        if (this._cartPrefab == null)
            return;
        GameObject _0x8c234c8d = Instantiate(this._cartPrefab, _0xf2f88939);
        this._0xc7da3a03 = _0x8c234c8d.transform;
        this._0xc7da3a03.localPosition = new Vector3(this._0x6bda5730[this._0xf6a6d7d6], _0x15963b9c, 0f);
        this._0xc7da3a03.localScale = Vector3.one;
        this._0x41d84545 = _0x8c234c8d.GetComponent<SpriteRenderer>();
        if (this._0x41d84545 != null)
        {
            float width = _0x89ef8149 * _0x6268eeb2.CartWidthOfLane;
            this._0x41d84545.drawMode = SpriteDrawMode.Sliced;
            this._0x41d84545.size = new Vector2(width, width);
            this._0x41d84545.sortingOrder = _0x6268eeb2.OrderCart;
        }
    }

    private int _0xe84d5885 = -1;
    public void _0xa2c962ba()
    {
        if (this._0xc7da3a03 == null)
            return;
        DOTween.Kill(this._0xc7da3a03, true);
        this._0xc7da3a03.localRotation = Quaternion.identity;
        this._0xc7da3a03.localPosition = new Vector3(this._0x6bda5730[this._0xf6a6d7d6], this._0xffd258e5, 0f);
        this._0x405b5820 = false;
        this._0x0a0ac93d = false;
        this._0xe84d5885 = -1;
    }

    private Transform _0xc7da3a03;
    private float[] _0x6bda5730 = new float[_0x6268eeb2.Lanes];
    // A horizontal swipe wins when it is long enough and more sideways than vertical;
    // otherwise the gesture counts as a tap and the screen third decides.
    private int _0xacacb823(Vector2 _0x62f93ef0, Vector2 _0x2a4a8461)
    {
        float _0x8071b672 = _0x2a4a8461.x - _0x62f93ef0.x;
        float _0xfdb4b1af = _0x2a4a8461.y - _0x62f93ef0.y;
        if (Mathf.Abs(_0x8071b672) > this._0x720fb251 && Mathf.Abs(_0x8071b672) > Mathf.Abs(_0xfdb4b1af))
            return _0x8071b672 > 0f ? 1 : -1;
        float _0x0ddcb05a = Screen.width / 3f;
        if (_0x2a4a8461.x < _0x0ddcb05a)
            return -1;
        if (_0x2a4a8461.x > _0x0ddcb05a * 2f)
            return 1;
        return 0;
    }

    private bool _0x405b5820;
    public int _0xad7133e9
    {
        get
        {
            return this._0xf6a6d7d6;
        }
    }

    private int _0x3deb7c3c()
    {
        Pointer _0xd87a500d = Pointer.current;
        if (_0xd87a500d == null || ETouch.activeTouches.Count > 0)
            return 0;
        Vector2 _0xd1069a89 = _0xd87a500d.position.ReadValue();
        if (_0xd1069a89.y > this._0x67c41c2f)
            return 0;
        if (_0xd87a500d.press.wasPressedThisFrame)
        {
            this._0x0a0ac93d = true;
            this._0xd2374818 = _0xd1069a89;
            return 0;
        }

        if (_0xd87a500d.press.wasReleasedThisFrame && this._0x0a0ac93d)
        {
            this._0x0a0ac93d = false;
            return this._0xacacb823(this._0xd2374818, _0xd1069a89);
        }

        return 0;
    }

    private Vector2 _0xd2374818;
    // EnhancedTouch is read directly: this template's InputController keeps its own
    // instance and every accessor private, so it cannot be called from here.
    private int _0xc2598c98()
    {
        if (ETouch.activeTouches.Count == 0)
            return 0;
        for (int _0x55491691 = 0; _0x55491691 < ETouch.activeTouches.Count; _0x55491691++)
        {
            ETouch _0xb008e7de = ETouch.activeTouches[_0x55491691];
            Vector2 _0x2bc89652 = _0xb008e7de.screenPosition;
            if (_0x2bc89652.y > this._0x67c41c2f)
                continue;
            if (_0xb008e7de.phase == UnityEngine.InputSystem.TouchPhase.Began)
            {
                this._0x0a0ac93d = true;
                this._0xe84d5885 = _0xb008e7de.touchId;
                this._0xd2374818 = _0x2bc89652;
                continue;
            }

            bool _0x8d4b9237 = _0xb008e7de.phase == UnityEngine.InputSystem.TouchPhase.Ended || _0xb008e7de.phase == UnityEngine.InputSystem.TouchPhase.Canceled;
            if (!_0x8d4b9237 || !this._0x0a0ac93d || _0xb008e7de.touchId != this._0xe84d5885)
                continue;
            this._0x0a0ac93d = false;
            this._0xe84d5885 = -1;
            return this._0xacacb823(this._0xd2374818, _0x2bc89652);
        }

        return 0;
    }
}