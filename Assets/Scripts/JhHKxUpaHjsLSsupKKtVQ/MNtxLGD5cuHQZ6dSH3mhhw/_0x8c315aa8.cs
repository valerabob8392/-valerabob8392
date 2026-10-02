using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x8c315aa8 : MonoBehaviour
{
    private bool _0x83109ee1(Touch? _0x1811d741, Bounds _0x808c953a, TouchPhase _0xb19ebdc3)
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
        {
            _0x1811d741 = null;
            return false;
        }

        if (_0x1811d741 != null)
            if (_0x1811d741.Value.phase == _0xb19ebdc3)
            {
                Vector3 _0x4b83b3ae = Camera.main.ScreenToWorldPoint(_0x1811d741.Value.screenPosition);
                Vector3 _0x7e2cf3d7 = new(_0x4b83b3ae.x, _0x4b83b3ae.y, _0x808c953a.center.z);
                if (_0x808c953a.Contains(_0x7e2cf3d7) && this._0xeb236ad1(_0x1811d741.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x4f2b0f82(Bounds _0xad8cb4b1)
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
            return null;
        foreach (Touch _0x3fc8f922 in Touch.activeTouches)
            if (_0x3fc8f922.ended)
            {
                Vector3 _0xf3ef2a77 = Camera.main.ScreenToWorldPoint(_0x3fc8f922.screenPosition);
                Vector3 _0x1c3d0a46 = new(_0xf3ef2a77.x, _0xf3ef2a77.y, _0xad8cb4b1.center.z);
                if (_0xad8cb4b1.Contains(_0x1c3d0a46) && this._0xeb236ad1(_0x3fc8f922))
                    return _0x3fc8f922;
            }

        return null;
    }

    private Touch? _0xd3a80ab0()
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
            return null;
        foreach (Touch _0x8acac62f in Touch.activeTouches)
            if (!_0x8acac62f.ended)
                if (this._0xeb236ad1(_0x8acac62f))
                    return _0x8acac62f;
        return null;
    }

    private Touch? _0xbe49d1a4()
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
            return null;
        foreach (Touch _0x5c1cf68e in Touch.activeTouches)
            if (_0x5c1cf68e.ended)
                if (this._0xeb236ad1(_0x5c1cf68e))
                    return _0x5c1cf68e;
        return null;
    }

    private Touch? _0x34c11d85(Bounds _0x041d651c, TouchPhase _0x4e02fb47)
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
            return null;
        foreach (Touch _0x2fcd38bb in Touch.activeTouches)
            if (_0x2fcd38bb.phase == _0x4e02fb47)
            {
                Vector3 _0xc8013b76 = Camera.main.ScreenToWorldPoint(_0x2fcd38bb.screenPosition);
                Vector3 _0xd933957a = new(_0xc8013b76.x, _0xc8013b76.y, _0x041d651c.center.z);
                if (_0x041d651c.Contains(_0xd933957a) && this._0xeb236ad1(_0x2fcd38bb))
                    return _0x2fcd38bb;
            }

        return null;
    }

    private bool _0xeb236ad1(Touch? _0x0634e387)
    {
        if (!_0x0634e387.HasValue)
            return false;
        Vector3 _0x7f016b94 = Camera.main.ScreenToWorldPoint(_0x0634e387.Value.screenPosition);
        Vector3 _0xbc638892 = _0x7f016b94;
        _0xbc638892.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xbc638892))
            return true;
        _0x0634e387 = null;
        return false;
    }

    public BoxCollider2D CameraTouchBounds;
    private static _0x8c315aa8 _0x8764fabb;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x8764fabb = this.gameObject.GetComponent<_0x8c315aa8>();
    }

    private Touch? _0xa80fe554(Bounds _0x8ba43955)
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
            return null;
        foreach (Touch _0x6957c29a in Touch.activeTouches)
            if (!_0x6957c29a.ended)
            {
                Vector3 _0x0b59a7a2 = Camera.main.ScreenToWorldPoint(_0x6957c29a.screenPosition);
                Vector3 _0x5f802ef4 = new(_0x0b59a7a2.x, _0x0b59a7a2.y, _0x8ba43955.center.z);
                if (_0x8ba43955.Contains(_0x5f802ef4) && this._0xeb236ad1(_0x6957c29a))
                    return _0x6957c29a;
            }

        return null;
    }

    private void _0x511cde4c(Touch? _0x90f1da0c)
    {
        if (!_0x847661bf.Instance._0xc5443ffc)
        {
            _0x90f1da0c = null;
            return;
        }

        int _0x586c8bff = _0x90f1da0c.Value.touchId;
        _0x90f1da0c = Touch.activeTouches.FirstOrDefault(_0xf5d5e051 => _0xf5d5e051.touchId == _0x586c8bff);
        if (!this._0xeb236ad1(_0x90f1da0c.Value))
            _0x90f1da0c = null;
    }
}