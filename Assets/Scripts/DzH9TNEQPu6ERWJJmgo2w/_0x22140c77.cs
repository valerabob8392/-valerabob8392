using System.Collections.Generic;
using UnityEngine;

// The scrolling surface: a ring of road tiles with grass verges either side and lane
// markings between the rails. Every size here is derived from the camera rect the
// director measured, never from a sprite's native pixels (rule C.0).
public sealed class _0x22140c77 : MonoBehaviour
{
    private void _0x3fcf107d(List<Transform> _0x1e8af90d, float distance, float _0x0a0f15d7)
    {
        if (_0x0a0f15d7 <= 0f)
            return;
        float span = this._0xe043e014;
        for (int _0x58bbb816 = 0; _0x58bbb816 < _0x1e8af90d.Count; _0x58bbb816++)
        {
            Transform _0x1804bd1d = _0x1e8af90d[_0x58bbb816];
            if (_0x1804bd1d == null)
                continue;
            Vector3 _0xed80a275 = _0x1804bd1d.localPosition;
            _0xed80a275.y -= distance;
            while (_0xed80a275.y < this._0xd82e7c65)
                _0xed80a275.y += span;
            _0x1804bd1d.localPosition = _0xed80a275;
        }
    }

    public void _0x13c3d997(float distance)
    {
        this._0x3fcf107d(this._0x331a0bcf, distance, this._0x3a3e054a);
        this._0x3fcf107d(this._0x13c54711, distance, this._0x3a3e054a);
        this._0x3fcf107d(this._0x838c18bf, distance, this._0x99f738c9);
    }

    private readonly List<Transform> _0x13c54711 = new List<Transform>();
    [SerializeField]
    private GameObject _roadTilePrefab;
    private float _0xd82e7c65;
    private float _0x3a3e054a;
    private readonly List<Transform> _0x331a0bcf = new List<Transform>();
    private float _0x99f738c9;
    private float _0xe043e014;
    public void _0xa61cf544(Transform _0x13d9db5e, float _0x685f7be2, float _0x0696c831, float _0xef10eb58, float _0xbc71f6f0)
    {
        int _0x6e720198 = Mathf.RoundToInt(_0x6268eeb2.TileRows);
        this._0xe043e014 = 2f * _0x0696c831 * 1.3f;
        this._0x3a3e054a = this._0xe043e014 / _0x6e720198;
        this._0xd82e7c65 = -_0x0696c831 - this._0x3a3e054a;
        float _0x39526712 = _0xbc71f6f0 * _0x6268eeb2.VergeWidthOfLane;
        float _0x97693fa5 = (_0xef10eb58 * 0.5f) + (_0x39526712 * 0.5f);
        if (_0x97693fa5 + (_0x39526712 * 0.5f) > _0x685f7be2)
            _0x97693fa5 = _0x685f7be2 - (_0x39526712 * 0.5f);
        for (int _0xc6d5d6c4 = 0; _0xc6d5d6c4 < _0x6e720198; _0xc6d5d6c4++)
        {
            float _0x1299bba5 = this._0xd82e7c65 + (_0xc6d5d6c4 * this._0x3a3e054a) + (this._0x3a3e054a * 0.5f);
            Transform _0xf26d0cbe = this._0x9b08ca81(this._roadTilePrefab, _0x13d9db5e, new Vector3(0f, _0x1299bba5, 0f), new Vector2(_0xef10eb58, this._0x3a3e054a), _0x6268eeb2.OrderRoad);
            if (_0xf26d0cbe != null)
                this._0x331a0bcf.Add(_0xf26d0cbe);
            for (int _0x4d12af61 = 0; _0x4d12af61 < 2; _0x4d12af61++)
            {
                float _0xebf4ed47 = _0x4d12af61 == 0 ? -_0x97693fa5 : _0x97693fa5;
                Transform _0x7abe8218 = this._0x9b08ca81(this._vergePrefab, _0x13d9db5e, new Vector3(_0xebf4ed47, _0x1299bba5, 0f), new Vector2(_0x39526712, this._0x3a3e054a), _0x6268eeb2.OrderVerge);
                if (_0x7abe8218 != null)
                    this._0x13c54711.Add(_0x7abe8218);
            }
        }

        int _0x7a4a25d9 = Mathf.RoundToInt(_0x6268eeb2.StripesPerLane);
        this._0x99f738c9 = this._0xe043e014 / _0x7a4a25d9;
        Vector2 _0x5aaaf43b = new Vector2(_0xbc71f6f0 * _0x6268eeb2.StripeWidthOfLane, _0xbc71f6f0 * _0x6268eeb2.StripeHeightOfLane);
        for (int _0x6269502a = 0; _0x6269502a < _0x7a4a25d9; _0x6269502a++)
        {
            float _0x890fa7fc = this._0xd82e7c65 + (_0x6269502a * this._0x99f738c9) + (this._0x99f738c9 * 0.5f);
            for (int _0x625a5581 = 0; _0x625a5581 < 2; _0x625a5581++)
            {
                float _0x608ce42e = _0x625a5581 == 0 ? -_0xbc71f6f0 * 0.5f : _0xbc71f6f0 * 0.5f;
                Transform _0x0a1052e0 = this._0x9b08ca81(this._stripePrefab, _0x13d9db5e, new Vector3(_0x608ce42e, _0x890fa7fc, 0f), _0x5aaaf43b, _0x6268eeb2.OrderStripe);
                if (_0x0a1052e0 != null)
                    this._0x838c18bf.Add(_0x0a1052e0);
            }
        }
    }

    [SerializeField]
    private GameObject _vergePrefab;
    [SerializeField]
    private GameObject _stripePrefab;
    private Transform _0x9b08ca81(GameObject _0xf204eb62, Transform _0x2372d460, Vector3 _0x91cb92ae, Vector2 _0xbfb92330, int _0xa8f286ac)
    {
        if (_0xf204eb62 == null)
            return null;
        GameObject _0x20704d1d = Instantiate(_0xf204eb62, _0x2372d460);
        _0x20704d1d.transform.localPosition = _0x91cb92ae;
        _0x20704d1d.transform.localScale = Vector3.one;
        SpriteRenderer _0xf9948626 = _0x20704d1d.GetComponent<SpriteRenderer>();
        if (_0xf9948626 != null)
        {
            _0xf9948626.drawMode = SpriteDrawMode.Sliced;
            _0xf9948626.size = _0xbfb92330;
            _0xf9948626.sortingOrder = _0xa8f286ac;
        }

        return _0x20704d1d.transform;
    }

    private readonly List<Transform> _0x838c18bf = new List<Transform>();
}