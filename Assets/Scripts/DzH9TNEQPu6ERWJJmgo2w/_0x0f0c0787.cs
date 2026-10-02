using UnityEngine;

// Owns one delivery run in 2_GameScene: measures the camera, builds the road, the cart,
// the HUD and the three result cards, then drives the clock and the road.
//
// Balance note (rule C.5), all of it measured on a port of this loop rather than argued:
// nothing can hit a player who never moves, because an obstacle is never dropped on the
// rail the cart is sitting in, and the wanted crate only lands there once every
// GraceEvery crates. A run that never touches the screen therefore takes NO strike, wins
// NOTHING, and lasts 68-85 s on the three routes - the review capture needs 10-26 s of it.
// Driving blind into every crate strikes out in well under a minute; timing the lane
// change past the obstacle row finishes all 28 in 38-49 s depending on the route.
public sealed class _0x0f0c0787 : MonoBehaviour
{
    private float _0x03e39782;
    private void Start()
    {
        this._0x0eb6cdf4 = _0x6268eeb2.ClampRoute(_0xdb1b25f0._0xbb95ef03);
        _0xdb1b25f0.CountAttempt(this._0x0eb6cdf4);
        this._0x6f053e40 = _0x8642392e.Build(this._0x0eb6cdf4, _0xdb1b25f0.Attempt(this._0x0eb6cdf4));
        this._0x0f5dc099 = _0x6268eeb2.RouteSeconds[this._0x0eb6cdf4];
        this._0xd3b1196b = _0x6268eeb2.RouteSpeedMultiplier[this._0x0eb6cdf4];
        this._0x5ef3b490 = _0x6268eeb2.StartDelay;
        Camera _0x22df1224 = Camera.main;
        float _0x6fb72a10 = _0x22df1224 != null ? _0x22df1224.orthographicSize : 5f;
        float _0x7085ed6f = _0x22df1224 != null ? _0x22df1224.aspect : 9f / 19.5f;
        float _0x00901524 = _0x6fb72a10 * _0x7085ed6f;
        float _0x9125b8ad = 2f * _0x6fb72a10;
        float _0x82d27f3f = 2f * _0x00901524 * _0x6268eeb2.RoadFraction;
        float _0x7af98c3d = _0x82d27f3f / _0x6268eeb2.Lanes;
        float[] _0x588a2beb = new float[_0x6268eeb2.Lanes];
        for (int _0x618a26f8 = 0; _0x618a26f8 < _0x6268eeb2.Lanes; _0x618a26f8++)
            _0x588a2beb[_0x618a26f8] = (_0x618a26f8 - 1) * _0x7af98c3d;
        float _0x03759d2b = -_0x6fb72a10 + (_0x9125b8ad * _0x6268eeb2.CartLiftFraction);
        float _0x7421f356 = _0x6fb72a10 + (_0x9125b8ad * _0x6268eeb2.SpawnLiftFraction);
        float _0x8d9c9a66 = -_0x6fb72a10 - (_0x9125b8ad * _0x6268eeb2.SpawnLiftFraction);
        this._0xbd4bbe95 = _0x9125b8ad * _0x6268eeb2.ScrollStartOfHeight;
        this._0xfd0ef867 = _0x9125b8ad * _0x6268eeb2.ScrollEndOfHeight;
        this._0x88aae838 = _0x7421f356 - _0x03759d2b;
        GameObject _0xdc5f027b = new GameObject(_0x1d0460a9._0x44d780fd(new byte[9] { 50, 15, 1, 4, 51, 20, 1, 7, 5 }, 96));
        _0xdc5f027b.transform.SetParent(this.transform, false);
        this._0xb03e87d9 = _0xdc5f027b.transform;
        if (this._world != null)
            this._world._0xa61cf544(this._0xb03e87d9, _0x00901524, _0x6fb72a10, _0x82d27f3f, _0x7af98c3d);
        if (this._pilot != null)
            this._pilot._0x1570d471(this._0xb03e87d9, _0x588a2beb, _0x03759d2b, _0x7af98c3d);
        if (this._spawner != null)
            this._spawner._0x5c850f12(this._0xb03e87d9, _0x588a2beb, _0x7421f356, _0x8d9c9a66, _0x03759d2b, _0x7af98c3d);
        Transform _0x403ff8d1 = this._0xf960f43f();
        this._0xcbceee30(_0x403ff8d1);
        if (this._hud != null && _0x403ff8d1 != null)
            this._hud._0xdfeb293e(_0x403ff8d1, this._crateSprites, () => this._0x80b45e8e(), () => this._0xb31d74fa());
        if (this._pops != null)
        {
            this._pops._0x1462ac28(_0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.WIN), () => this._0xdbd1ca38(), () => this._0x80b45e8e(), () => this._0x80b45e8e());
            this._pops._0xce5a35de(_0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.LOSE), () => this._0x21f51282(), () => this._0x80b45e8e(), () => this._0x80b45e8e());
            this._pops._0x1ae0ab6c(_0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.PAUSE), () => this._0x206617e2(), () => this._0x80b45e8e(), () => this._0x206617e2());
        }

        this._0xc36ea58e();
    }

    private void Update()
    {
        if (this._0x50e20f1a || this._0x6f053e40 == null)
            return;
        bool _0x07e8355e = _0x847661bf.Instance != null && _0x847661bf.Instance._0xc5443ffc;
        if (!_0x07e8355e)
        {
            this._0x9289e174 = false;
            return;
        }

        if (!this._0x9289e174)
        {
            // Coming back from a pop: HideAllPops switches the template HUD back on.
            this._0x9289e174 = true;
            this._0xcbceee30(this._0xf960f43f());
        }

        float step = Time.deltaTime;
        if (this._0x03e39782 > 0f)
            this._0x03e39782 -= step;
        float _0x7b063c5d = Mathf.Clamp01((float)this._0xac01beb7 / _0x6268eeb2.CratesPerRoute);
        float _0x70699009 = Mathf.Lerp(this._0xbd4bbe95, this._0xfd0ef867, _0x7b063c5d) * this._0xd3b1196b;
        if (this._0x03e39782 > 0f)
            _0x70699009 *= _0x6268eeb2.StumbleScroll;
        float _0xa25c78c3 = _0x70699009 * step;
        if (this._world != null)
            this._world._0x13c3d997(_0xa25c78c3);
        if (this._pilot != null)
        {
            int _0x124e03d1 = this._pilot._0x2ca96daa();
            if (_0x124e03d1 != this._pilot._0xad7133e9)
                this._pilot._0xa9403bdc(_0x124e03d1);
        }

        if (this._spawner != null && this._pilot != null)
        {
            this._spawner._0x8fe9bff2();
            this._spawner._0x3e477edb(_0xa25c78c3, this._pilot._0xad7133e9, this._0x6f053e40._0x911ffe1c(this._0xac01beb7));
            this._0x52f5c744();
            if (this._0x50e20f1a)
                return;
        }

        this._0x1d1d218e(step, _0x70699009);
        this._0x0f5dc099 -= step;
        if (this._hud != null)
            this._hud._0x7566c853(this._0x0f5dc099);
        if (this._0x0f5dc099 <= 0f)
            this._0xe8af6a8c(false, _0x1d0460a9._0x44d780fd(new byte[11] { 24, 2, 3, 119, 24, 17, 119, 3, 30, 26, 18 }, 87));
    }

    // The template HUD is drawn for a different game, so everything the panel shipped
    // with is switched off and this game's own HUD is built beside it (rule C.2).
    // Branches that hold a Pop are left alone - those are live result cards.
    private void _0xcbceee30(Transform _0x6550adad)
    {
        if (_0x6550adad == null)
            return;
        for (int _0x0377180c = 0; _0x0377180c < _0x6550adad.childCount; _0x0377180c++)
        {
            Transform _0x2c8f739a = _0x6550adad.GetChild(_0x0377180c);
            if (_0x2c8f739a == null || _0x2c8f739a == this.transform)
                continue;
            if (_0x2c8f739a.GetComponentInChildren<_0xc36ede33>(true) != null)
                continue;
            if (this._hud != null && this._hud._0x74083df0 != null && _0x2c8f739a == this._hud._0x74083df0)
                continue;
            _0x2c8f739a.gameObject.SetActive(false);
        }
    }

    private float _0x682a7846;
    private void _0x206617e2()
    {
        _0x6a657270.Instance._0x42a33b89();
        this._0xcbceee30(this._0xf960f43f());
        if (_0x847661bf.Instance != null)
            _0x847661bf.Instance._0x6c61b7ff(true);
    }

    // The road runs on a two-phase cycle rather than a fixed clock.
    //
    // Phase 1 sends ONE wanted crate, and only once the previous one has left the road.
    // That is what keeps the three queue chips honest: the queue cannot advance while a
    // crate is in flight, so the colour coming down the road is always the colour the
    // chips say is next. It also means a crate that slips past costs nothing but time -
    // the same colour is simply sent again, so all 28 stay reachable.
    //
    // Phase 2 drops the obstacle row partway through that flight, into a rail that is
    // neither the cart's nor the crate's. By the time the NEXT crate appears the row is
    // already on the road, which is where the whole difficulty of the game lives: the
    // player can always get across, but only by timing the move.
    private void _0x1d1d218e(float step, float _0x6eef1628)
    {
        if (this._0x6f053e40 == null || this._spawner == null || this._pilot == null)
            return;
        if (this._0x6f053e40._0xf939b1f6 <= 0)
            return;
        if (this._0x5ef3b490 > 0f)
        {
            this._0x5ef3b490 -= step;
            return;
        }

        if (this._spawner._0x3ecacbe3 == 0)
        {
            int _0x87fa218e = this._0xff3a1286 % this._0x6f053e40._0xf939b1f6;
            int _0xcf159c02 = this._0x6f053e40.TargetLane[_0x87fa218e];
            // The wanted crate may land on the rail the cart is already sitting in only
            // once every GraceEvery crates. Left to chance it would do so one time in
            // three, which is enough for a player who never touches the screen to finish
            // the route standing still - measured, not assumed.
            bool _0x42a87a45 = (this._0x06a0f07a % _0x6268eeb2.GraceEvery) == 0;
            if (!_0x42a87a45 && _0xcf159c02 == this._pilot._0xad7133e9)
                _0xcf159c02 = (this._pilot._0xad7133e9 + 1 + (this._0xff3a1286 % (_0x6268eeb2.Lanes - 1))) % _0x6268eeb2.Lanes;
            this._spawner._0x9a9c134e(this._0x6f053e40._0x911ffe1c(this._0xac01beb7), _0xcf159c02);
            this._0x06a0f07a = this._0x06a0f07a + 1;
            this._0xff3a1286 = this._0xff3a1286 + 1;
            this._0x682a7846 = (this._0x88aae838 / Mathf.Max(0.01f, _0x6eef1628)) * _0x6268eeb2.RowDelayOfTravel;
            this._0x80149428 = false;
            return;
        }

        if (this._0x80149428)
            return;
        this._0x682a7846 -= step;
        if (this._0x682a7846 > 0f)
            return;
        int _0xdf0cf9a5 = ((this._0xff3a1286 - 1) + this._0x6f053e40._0xf939b1f6) % this._0x6f053e40._0xf939b1f6;
        this._spawner._0x48ddd397(this._0x6f053e40._0x911ffe1c(this._0xac01beb7), this._0x6f053e40.HasDecoy[_0xdf0cf9a5], this._0x6f053e40.HasHazard[_0xdf0cf9a5], this._pilot._0xad7133e9, this._0xff3a1286);
        this._0x80149428 = true;
    }

    private float _0xfd0ef867;
    private int _0x0eb6cdf4;
    private float _0x0f5dc099;
    [SerializeField]
    private _0xe5b53668 _pops;
    [SerializeField]
    private _0x22140c77 _world;
    private int _0x6a74a675;
    private int _0xec676d64;
    private int _0x06a0f07a;
    private void _0xe8af6a8c(bool _0xbbeefe9e, string _0x778fc861)
    {
        if (this._0x50e20f1a)
            return;
        this._0x50e20f1a = true;
        if (this._spawner != null)
            this._spawner._0xa1894841();
        if (this._pilot != null)
            this._pilot._0xa2c962ba();
        _0xdb1b25f0.RecordBest(this._0x0eb6cdf4, this._0xac01beb7);
        _0xdb1b25f0.AddDelivered(this._0xac01beb7);
        int _0x71ce6aea = this._0x1122a13f();
        if (_0xbbeefe9e)
        {
            bool _0xae10b4f1 = this._0x0eb6cdf4 + 1 < _0x6268eeb2.RouteSeconds.Length;
            _0xdb1b25f0.Unlock(this._0x0eb6cdf4 + 2);
            if (this._pops != null)
                this._pops._0x42492dbe(this._0xac01beb7, _0x71ce6aea, this._0xf617a484, _0xae10b4f1 ? _0x1d0460a9._0x44d780fd(new byte[10] { 147, 152, 133, 137, 253, 143, 146, 136, 137, 152 }, 221) : _0x1d0460a9._0x44d780fd(new byte[9] { 238, 233, 242, 156, 253, 251, 253, 245, 242 }, 188));
            _0xc36ede33 _0x3019ef95 = _0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.WIN);
            if (_0x3019ef95 != null)
                _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.WIN);
        }
        else
        {
            if (this._pops != null)
                this._pops._0x2099ba79(_0x778fc861, this._0xac01beb7, _0x71ce6aea, this._0xf617a484);
            _0xc36ede33 _0x7a34b19f = _0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.LOSE);
            if (_0x7a34b19f != null)
                _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.LOSE);
        }

        if (_0x847661bf.Instance != null)
            _0x847661bf.Instance._0x6c61b7ff(false);
    }

    private void _0xdbd1ca38()
    {
        int _0xa0a9b79d = this._0x0eb6cdf4 + 1;
        if (_0xa0a9b79d >= _0x6268eeb2.RouteSeconds.Length)
            _0xa0a9b79d = this._0x0eb6cdf4;
        _0xdb1b25f0._0xbb95ef03 = _0xa0a9b79d;
        this._0x21f51282();
    }

    private void _0xc36ea58e()
    {
        if (this._hud == null || this._0x6f053e40 == null)
            return;
        this._hud._0x9e048bb3(this._0xac01beb7, _0x6268eeb2.CratesPerRoute);
        this._hud._0x3636f6f3(this._0x04849541);
        this._hud._0xdff1ffc9(this._0xf6906507(0), this._0xf6906507(1), this._0xf6906507(2));
    }

    private Transform _0xb03e87d9;
    [SerializeField]
    private _0x752c26f3 _hud;
    private void _0xb31d74fa()
    {
        if (this._0x50e20f1a)
            return;
        if (this._pops != null)
            this._pops._0x89a76e18(this._0xac01beb7, this._0x0f5dc099);
        _0xc36ede33 _0x8eeb62cc = _0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.PAUSE);
        if (_0x8eeb62cc == null)
            return;
        if (_0x847661bf.Instance != null)
            _0x847661bf.Instance._0x6c61b7ff(false);
        _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.PAUSE);
    }

    private bool _0x50e20f1a;
    private int _0x1122a13f()
    {
        int _0x86d1296b = this._0xac01beb7 + this._0x6a74a675 + this._0xec676d64;
        if (_0x86d1296b <= 0)
            return 0;
        return Mathf.RoundToInt((100f * this._0xac01beb7) / _0x86d1296b);
    }

    private float _0x88aae838;
    private float _0xd3b1196b = 1f;
    private int _0xac01beb7;
    private int _0xf6906507(int _0x807aaa15)
    {
        int _0x97f5db9b = this._0xac01beb7 + _0x807aaa15;
        if (this._0x6f053e40 == null || _0x97f5db9b >= _0x6268eeb2.CratesPerRoute)
            return -1;
        return this._0x6f053e40._0x911ffe1c(_0x97f5db9b);
    }

    private bool _0x80149428 = true;
    [SerializeField]
    private Sprite[] _crateSprites;
    private void _0x21f51282()
    {
        if (_0x847661bf.Instance == null)
            return;
        _0x847661bf.Instance._0x6c61b7ff(true);
        _0x847661bf.Instance.LoadSceneByIndex(_0xb7a79f4e._0x0972bb08.SCENE_1);
    }

    private int _0xf617a484;
    private Transform _0xf960f43f()
    {
        _0x57de1605 _0xd474d4a2 = _0x57de1605.Instance;
        if (_0xd474d4a2 == null || _0xd474d4a2.Panels == null)
            return null;
        int _0x675a6e04 = _0xb7a79f4e._0x4a0666d8.DEFAULT;
        if (_0x675a6e04 < 0 || _0x675a6e04 >= _0xd474d4a2.Panels.Count)
            return null;
        _0x3dafaafe _0x2a7a0d7b = _0xd474d4a2.Panels[_0x675a6e04];
        if (_0x2a7a0d7b == null || _0x2a7a0d7b.Content == null)
            return null;
        return _0x2a7a0d7b.Content.transform;
    }

    private _0x1c389699 _0x6f053e40;
    private void _0x80b45e8e()
    {
        if (_0x847661bf.Instance == null)
            return;
        _0x847661bf.Instance._0x6c61b7ff(true);
        _0x847661bf.Instance.LoadSceneByIndex(_0xb7a79f4e._0x0972bb08.SCENE_0);
    }

    [SerializeField]
    private _0x08cd28a2 _spawner;
    private int _0x96416ef8;
    private float _0x5ef3b490;
    [SerializeField]
    private _0xf2bb88a2 _pilot;
    private void _0x52f5c744()
    {
        _0x08cd28a2 _0xa6a3e2f3 = this._spawner;
        if (_0xa6a3e2f3 == null)
            return;
        if (_0xa6a3e2f3.TookCorrect > 0)
        {
            this._0xac01beb7 = this._0xac01beb7 + _0xa6a3e2f3.TookCorrect;
            this._0x96416ef8 = this._0x96416ef8 + _0xa6a3e2f3.TookCorrect;
            if (this._0x96416ef8 > this._0xf617a484)
                this._0xf617a484 = this._0x96416ef8;
            this._0x0f5dc099 = Mathf.Min(_0x6268eeb2.TimeCap, this._0x0f5dc099 + (_0x6268eeb2.TimeBonus * _0xa6a3e2f3.TookCorrect));
            if (this._hud != null)
                this._hud._0x80e4eb50();
            this._0xc36ea58e();
            if (this._0xac01beb7 >= _0x6268eeb2.CratesPerRoute)
            {
                this._0xe8af6a8c(true, _0x1d0460a9._0x44d780fd(new byte[15] { 64, 93, 71, 70, 87, 50, 86, 87, 94, 91, 68, 87, 64, 87, 86 }, 18));
                return;
            }
        }

        int _0x645853b8 = _0xa6a3e2f3.TookWrong + _0xa6a3e2f3.Struck;
        if (_0x645853b8 > 0)
        {
            this._0x04849541 = this._0x04849541 + _0x645853b8;
            this._0x6a74a675 = this._0x6a74a675 + _0x645853b8;
            this._0x96416ef8 = 0;
            if (this._hud != null)
            {
                this._hud._0x6a79f470();
                this._hud._0x3636f6f3(this._0x04849541);
            }

            if (_0xa6a3e2f3.Struck > 0 && this._pilot != null)
            {
                this._pilot._0x4e874412();
                this._0x03e39782 = _0x6268eeb2.StumbleTime;
            }

            if (this._0x04849541 >= _0x6268eeb2.StrikesMax)
            {
                this._0xe8af6a8c(false, _0x1d0460a9._0x44d780fd(new byte[13] { 72, 75, 69, 64, 36, 87, 71, 86, 69, 84, 84, 65, 64 }, 4));
                return;
            }
        }

        if (_0xa6a3e2f3.Missed > 0)
        {
            this._0xec676d64 = this._0xec676d64 + _0xa6a3e2f3.Missed;
            this._0x96416ef8 = 0;
        }
    }

    private bool _0x9289e174;
    private int _0x04849541;
    private float _0xbd4bbe95;
    private int _0xff3a1286;
}

internal static class _0x1d0460a9
{
    internal static string _0x44d780fd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}