// Every number the run is balanced on, in one place. Sizes are FRACTIONS of
// camera-derived quantities (never world constants): the owning component turns them
// into world units from orthographicSize / aspect at runtime (rule C.0).
public static class _0x6268eeb2
{
    // Clock. The BASE route is 75 s with no pickup at all (rule C.5 floor is 60),
    // and the player tops it up by delivering. The first review frame lands around
    // the 15th second of the run and the last around the 31st - both inside a live run.
    public const float TimeBonus = 2f;
    public const int Lanes = 3;
    public const int CratesPerRoute = 28;
    public const int StrikesMax = 3;
    public static readonly float[] RouteSpeedMultiplier =
    {
        1f,
        1.15f,
        1.3f
    };
    public const float PickupWindowOfLane = 0.375f;
    // Pace. The scroll speed is in SCREEN HEIGHTS per second, so the reaction time a
    // player gets is the same on any aspect ratio.
    public const float ScrollStartOfHeight = 0.43f;
    public const float VergeWidthOfLane = 0.43f;
    // Road geometry as fractions of the visible camera rect.
    public const float RoadFraction = 0.78f; // road width / screen width
    public const float BurstWidthOfLane = 0.92f;
    public const float TimeCap = 90f;
    public static int ClampRoute(int _0x39cc59db)
    {
        if (_0x39cc59db < 0)
            return 0;
        if (_0x39cc59db >= RouteSeconds.Length)
            return RouteSeconds.Length - 1;
        return _0x39cc59db;
    }

    public const float LaneShiftTime = 0.16f;
    public const int OrderRoad = -18;
    public const float StumbleTime = 0.6f;
    public const float StartDelay = 0.6f;
    public const int OrderStripe = -17;
    public const float HintSolidTime = 12f;
    public const float TileRows = 5; // tiles in the scrolling ring
    public const float ScrollEndOfHeight = 0.56f;
    // How often the wanted crate is allowed to land on the rail the cart is already
    // sitting in. Every crate would do it one time in three by chance, which is enough
    // for a player who never touches the screen to finish the whole route standing still.
    public const int GraceEvery = 7;
    public const float StripeHeightOfLane = 0.79f;
    public const int OrderHazard = -10;
    public const float FinishFreeze = 0.5f;
    public const float StumbleScroll = 0.4f;
    public static readonly float[] RouteSeconds =
    {
        75f,
        70f,
        68f
    };
    public const float HazardWidthOfLane = 0.82f;
    public const int OrderBurst = -3;
    public const float CrateWidthOfLane = 0.6f;
    // Object widths as fractions of ONE lane, so the board scales with any aspect.
    public const float CartWidthOfLane = 0.8f;
    public const int OrderCart = -8;
    public const float StripeWidthOfLane = 0.058f;
    public static readonly string[] RouteTitle =
    {
        _0x90a66f8d._0xed40d3c0(new byte[11] { 81, 89, 93, 88, 83, 75, 60, 81, 85, 80, 89 }, 28),
        _0x90a66f8d._0xed40d3c0(new byte[11] { 110, 104, 115, 110, 120, 105, 29, 117, 124, 104, 113 }, 61),
        _0x90a66f8d._0xed40d3c0(new byte[13] { 79, 72, 70, 73, 85, 33, 71, 83, 68, 72, 70, 73, 85 }, 1)
    };
    // The obstacle row drops this far into the wanted crate's flight. By then the player
    // has committed to a rail, so the row is a decision for the NEXT crate: it is the
    // thing standing between the cart and wherever the next crate lands.
    public const float RowDelayOfTravel = 0.45f;
    public const float CartLiftFraction = 0.195f; // cart Y above the bottom edge / halfH
    public const float HintFadedAlpha = 0.6f;
    public const int OrderCrate = -9;
    public const float SpawnLiftFraction = 0.08f; // spawn Y above the top edge / halfH
    // How far a crate travels from the spawn line down to the cart, as a fraction of the
    // screen height. Everything about the pace follows from it: at the opening speed a
    // crate takes 0.885 / 0.43 = 2.06 s to arrive, at the closing speed 1.58 s. The road
    // is driven by that flight rather than by a fixed clock, so every route has the same
    // shape and only the reaction time shortens as the speed climbs.
    public const float TravelOfHeight = 1f + SpawnLiftFraction - CartLiftFraction;
    public const float StripesPerLane = 12;
    // Sorting band. Background canvas owns -30/-20 and the pops own 10 and up, so
    // every world sprite in this game lives strictly inside -19..-1 (rule C.21).
    public const int OrderVerge = -19;
}

internal static class _0x90a66f8d
{
    internal static string _0xed40d3c0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}