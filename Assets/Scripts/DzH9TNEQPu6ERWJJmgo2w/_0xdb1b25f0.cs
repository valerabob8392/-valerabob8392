using UnityEngine;

// Persistent run record. Keys are plain PlayerPrefs strings (data, not symbols), so
// obfuscation does not touch them. The lifetime crate total is mirrored into
// SETTINGS.PlayerSYSTEM.Coins, which is the counter the template already owns.
public static class _0xdb1b25f0
{
    private static readonly string PickKey = _0xbb45af07._0xcdc69659(new byte[14] { 65, 74, 75, 73, 77, 112, 77, 87, 86, 71, 114, 75, 65, 73 }, 34);
    public static void RecordBest(int _0xac5fe12b, int _0x669d951d)
    {
        if (_0x669d951d > Best(_0xac5fe12b))
            PlayerPrefs.SetInt(BestKey + _0xac5fe12b.ToString(), _0x669d951d);
    }

    public static void AddDelivered(int _0x369dceab)
    {
        if (_0x369dceab > 0)
            _0xb7a79f4e._0x53a33f42._0x81b0b0cd = _0xb7a79f4e._0x53a33f42._0x81b0b0cd + _0x369dceab;
    }

    private static readonly string TriesKey = _0xbb45af07._0xcdc69659(new byte[15] { 86, 93, 92, 94, 90, 103, 90, 64, 65, 80, 97, 71, 92, 80, 70 }, 53);
    private static readonly string BestKey = _0xbb45af07._0xcdc69659(new byte[14] { 210, 217, 216, 218, 222, 243, 212, 194, 197, 227, 222, 196, 197, 212 }, 177);
    private static readonly string OpenKey = _0xbb45af07._0xcdc69659(new byte[15] { 159, 148, 149, 151, 147, 174, 147, 137, 136, 153, 143, 179, 140, 153, 146 }, 252);
    public static int _0x8da23d77
    {
        get
        {
            return _0xb7a79f4e._0x53a33f42._0x81b0b0cd;
        }
    }

    public static void Unlock(int _0x6997b8fc)
    {
        int _0x2ddf9ee9 = Mathf.Clamp(_0x6997b8fc, 1, _0x6268eeb2.RouteSeconds.Length);
        if (_0x2ddf9ee9 > _0x03c4ad88)
            PlayerPrefs.SetInt(OpenKey, _0x2ddf9ee9);
    }

    public static int Best(int _0xebb5ecab)
    {
        return PlayerPrefs.GetInt(BestKey + _0xebb5ecab.ToString(), 0);
    }

    public static int _0xbb95ef03
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(PickKey, 0), 0, _0x03c4ad88 - 1);
        }

        set
        {
            PlayerPrefs.SetInt(PickKey, _0x6268eeb2.ClampRoute(value));
        }
    }

    public static void CountAttempt(int _0x30d55b01)
    {
        PlayerPrefs.SetInt(TriesKey + _0x30d55b01.ToString(), Attempt(_0x30d55b01) + 1);
    }

    // Routes unlock one at a time; route 0 is always open.
    public static int _0x03c4ad88
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(OpenKey, 1), 1, _0x6268eeb2.RouteSeconds.Length);
        }
    }

    public static int Attempt(int _0xc7a294a6)
    {
        return PlayerPrefs.GetInt(TriesKey + _0xc7a294a6.ToString(), 0);
    }
}

internal static class _0xbb45af07
{
    internal static string _0xcdc69659(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}