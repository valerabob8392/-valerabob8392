using UnityEngine;

// Builds a route from a seed, then PROVES it is deliverable before the player sees it.
// System.Random (not UnityEngine.Random) so the same route index + attempt always
// replays identically, and every run of the same route differs from the last (rule C.11).
public static class _0x8642392e
{
    public static _0x1c389699 Build(int _0x02b5ccc5, int _0x070e6b9b)
    {
        int _0x26e7e9b8 = _0x6268eeb2.ClampRoute(_0x02b5ccc5);
        for (int _0x379cc00a = 0; _0x379cc00a < MaxAttempts; _0x379cc00a++)
        {
            int _0x8d96c6ad = ((_0x26e7e9b8 + 1) * 7919) ^ ((_0x070e6b9b + _0x379cc00a + 1) * 104729);
            System.Random _0x77b7cf97 = new System.Random(_0x8d96c6ad);
            _0x1c389699 _0x72a75490 = Compose(_0x77b7cf97, _0x26e7e9b8, _0x8d96c6ad);
            if (IsRunnable(_0x72a75490))
            {
#if B_LOGS
                Debug.Log(_0x17ee1779._0x7a627edf(new byte[14] { 247, 222, 195, 217, 216, 201, 241, 140, 197, 194, 200, 201, 212, 145 }, 172) + _0x26e7e9b8.ToString() + _0x17ee1779._0x7a627edf(new byte[6] { 83, 0, 22, 22, 23, 78 }, 115) + _0x8d96c6ad.ToString() + _0x17ee1779._0x7a627edf(new byte[7] { 39, 112, 102, 113, 98, 116, 58 }, 7) + _0x72a75490._0xf939b1f6.ToString());
#endif
                return _0x72a75490;
            }
        }

        return Steady(_0x26e7e9b8);
    }

    // A plan is runnable when a perfect player can take every crate in order inside the
    // route clock. Two conditions, both checked rather than assumed:
    //   * the lane change the plan asks for (at most two lanes) finishes well before the
    //     crate arrives, so no crate is unreachable;
    //   * the whole order fits the clock. Only ONE wanted crate is on the road at a time
    //     and the next is sent the moment it leaves, so a perfect run costs exactly the sum
    //     of the flights - not one fixed wave each, which is what an earlier version of this
    //     check assumed and which flattered the route by about 25 seconds.
    private static bool IsRunnable(_0x1c389699 _0x61d55626)
    {
        if (_0x61d55626.Order.Count != _0x6268eeb2.CratesPerRoute)
            return false;
        if (_0x61d55626._0xf939b1f6 < _0x6268eeb2.CratesPerRoute)
            return false;
        float _0x2ed3f875 = _0x6268eeb2.RouteSpeedMultiplier[_0x61d55626.RouteIndex];
        // The shortest flight a crate ever has, i.e. the least reaction time the route
        // asks for. Crossing two rails has to fit inside it with room to spare.
        float _0x0f3d66ce = _0x6268eeb2.TravelOfHeight / (_0x6268eeb2.ScrollEndOfHeight * _0x2ed3f875);
        int _0x57d29dc5 = 1;
        for (int _0x84395678 = 0; _0x84395678 < _0x6268eeb2.CratesPerRoute; _0x84395678++)
        {
            int _0x61823bdf = _0x61d55626.TargetLane[_0x84395678];
            int _0xfddc88ca = Mathf.Abs(_0x61823bdf - _0x57d29dc5);
            if (_0xfddc88ca * _0x6268eeb2.LaneShiftTime >= _0x0f3d66ce * 0.5f)
                return false;
            _0x57d29dc5 = _0x61823bdf;
        }

        // One crate is on the road at a time and the next is sent the moment it leaves,
        // so a perfect run costs exactly the sum of the flights.
        float _0xfba8196d = _0x6268eeb2.StartDelay;
        for (int _0xa344d7a3 = 0; _0xa344d7a3 < _0x6268eeb2.CratesPerRoute; _0xa344d7a3++)
        {
            float _0x252f7433 = (float)_0xa344d7a3 / _0x6268eeb2.CratesPerRoute;
            float _0x28e4996a = Mathf.Lerp(_0x6268eeb2.ScrollStartOfHeight, _0x6268eeb2.ScrollEndOfHeight, _0x252f7433) * _0x2ed3f875;
            _0xfba8196d += _0x6268eeb2.TravelOfHeight / _0x28e4996a;
        }

        float _0x13445816 = Mathf.Min(_0x6268eeb2.TimeCap, _0x6268eeb2.RouteSeconds[_0x61d55626.RouteIndex]);
        float _0x441a14a1 = (_0x6268eeb2.CratesPerRoute - 1) * _0x6268eeb2.TimeBonus;
        return _0xfba8196d < _0x13445816 + _0x441a14a1;
    }

    private const int MinPerColour = 5;
    private const int MaxAttempts = 20;
    // Last resort only: a hand-built route that is runnable by construction. Reaching
    // this means the generator failed 20 seeds in a row, which the log will say.
    private static _0x1c389699 Steady(int _0xd54e07c5)
    {
        _0x1c389699 _0x11026cfa = new _0x1c389699();
        _0x11026cfa.RouteIndex = _0xd54e07c5;
        _0x11026cfa.Seed = 0;
        _0x11026cfa.IsFallback = true;
        for (int _0x64e5e083 = 0; _0x64e5e083 < _0x6268eeb2.CratesPerRoute; _0x64e5e083++)
        {
            _0x11026cfa.Order.Add(_0x64e5e083 % Colours);
            _0x11026cfa.TargetLane.Add(_0x64e5e083 % _0x6268eeb2.Lanes);
            _0x11026cfa.HasDecoy.Add(true);
            _0x11026cfa.HasHazard.Add(_0x64e5e083 % 2 == 0);
        }

        int _0xe54ec3c8 = (_0x6268eeb2.CratesPerRoute * 3) / 2;
        for (int _0x850df333 = _0x6268eeb2.CratesPerRoute; _0x850df333 < _0xe54ec3c8; _0x850df333++)
        {
            _0x11026cfa.TargetLane.Add(_0x850df333 % _0x6268eeb2.Lanes);
            _0x11026cfa.HasDecoy.Add(true);
            _0x11026cfa.HasHazard.Add(true);
        }

#if B_LOGS
        Debug.Log(_0x17ee1779._0x7a627edf(new byte[37] { 131, 170, 183, 173, 172, 189, 133, 248, 190, 185, 180, 180, 186, 185, 187, 179, 248, 168, 180, 185, 182, 248, 173, 171, 189, 188, 248, 190, 183, 170, 248, 177, 182, 188, 189, 160, 248 }, 216) + _0xd54e07c5.ToString());
#endif
        return _0x11026cfa;
    }

    private const int Colours = 4;
    private const int MaxRepeat = 2;
    private static _0x1c389699 Compose(System.Random _0x1ccfca3a, int _0x1fd2bc95, int _0x69907e5e)
    {
        _0x1c389699 _0x8cd3f3fe = new _0x1c389699();
        _0x8cd3f3fe.Seed = _0x69907e5e;
        _0x8cd3f3fe.RouteIndex = _0x1fd2bc95;
        int[] _0xd3f935b7 = new int[Colours];
        int _0xebf6a054 = -1;
        int _0x2db5532e = 0;
        for (int _0x181a5a48 = 0; _0x181a5a48 < _0x6268eeb2.CratesPerRoute; _0x181a5a48++)
        {
            int _0xaad27aca = _0x1ccfca3a.Next(Colours);
            for (int _0x7be678c1 = 0; _0x7be678c1 < 16; _0x7be678c1++)
            {
                bool _0x14aa2325 = _0xaad27aca == _0xebf6a054 && _0x2db5532e >= MaxRepeat;
                if (!_0x14aa2325)
                    break;
                _0xaad27aca = _0x1ccfca3a.Next(Colours);
            }

            _0x2db5532e = _0xaad27aca == _0xebf6a054 ? _0x2db5532e + 1 : 1;
            _0xebf6a054 = _0xaad27aca;
            _0xd3f935b7[_0xaad27aca] = _0xd3f935b7[_0xaad27aca] + 1;
            _0x8cd3f3fe.Order.Add(_0xaad27aca);
        }

        for (int _0xab14dbbe = 0; _0xab14dbbe < Colours; _0xab14dbbe++)
        {
            int _0x1169ce62 = 0;
            while (_0xd3f935b7[_0xab14dbbe] < MinPerColour && _0x1169ce62 < _0x8cd3f3fe.Order.Count)
            {
                int _0xca8306f3 = _0x8cd3f3fe.Order[_0x1169ce62];
                bool _0x692b9300 = _0xd3f935b7[_0xca8306f3] > MinPerColour;
                bool _0x23163166 = _0x1169ce62 == 0 || _0x8cd3f3fe.Order[_0x1169ce62 - 1] != _0xab14dbbe;
                bool _0x99f0bcdd = _0x1169ce62 == _0x8cd3f3fe.Order.Count - 1 || _0x8cd3f3fe.Order[_0x1169ce62 + 1] != _0xab14dbbe;
                if (_0x692b9300 && _0x23163166 && _0x99f0bcdd)
                {
                    _0x8cd3f3fe.Order[_0x1169ce62] = _0xab14dbbe;
                    _0xd3f935b7[_0xca8306f3] = _0xd3f935b7[_0xca8306f3] - 1;
                    _0xd3f935b7[_0xab14dbbe] = _0xd3f935b7[_0xab14dbbe] + 1;
                }

                _0x1169ce62++;
            }
        }

        // Enough cycles to deliver every crate with slack for the ones that slip past.
        int _0x728258fd = (_0x6268eeb2.CratesPerRoute * 3) / 2;
        int _0x578d2ae7 = 1;
        for (int _0xb0125a95 = 0; _0xb0125a95 < _0x728258fd; _0xb0125a95++)
        {
            _0x578d2ae7 = _0x1ccfca3a.Next(_0x6268eeb2.Lanes);
            _0x8cd3f3fe.TargetLane.Add(_0x578d2ae7);
            float _0xec301913 = _0x728258fd <= 1 ? 0f : (float)_0xb0125a95 / (float)(_0x728258fd - 1);
            double _0x4dd15854 = 0.55 + (0.3 * _0xec301913);
            double _0xdca522e9 = 0.45 + (0.35 * _0xec301913);
            _0x8cd3f3fe.HasDecoy.Add(_0x1ccfca3a.NextDouble() < _0x4dd15854);
            _0x8cd3f3fe.HasHazard.Add(_0x1ccfca3a.NextDouble() < _0xdca522e9);
        }

        return _0x8cd3f3fe;
    }
}

internal static class _0x17ee1779
{
    internal static string _0x7a627edf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}