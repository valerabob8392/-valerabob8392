using System.Collections.Generic;

// One generated route: the colour order the dispatcher wants, plus, per cycle, which
// rail the WANTED crate arrives on and whether that cycle also carries a decoy crate or
// a road hazard. The decoy/hazard RAILS are not stored: they are chosen when the row is
// dropped, against the cart's live rail, which is what keeps a passive run alive (rule C.5).
public sealed class _0x1c389699
{
    public readonly List<bool> HasHazard = new List<bool>();
    public int _0x911ffe1c(int _0x1a225336)
    {
        if (this.Order.Count == 0)
            return 0;
        if (_0x1a225336 < 0)
            _0x1a225336 = 0;
        if (_0x1a225336 >= this.Order.Count)
            _0x1a225336 = this.Order.Count - 1;
        return this.Order[_0x1a225336];
    }

    public readonly List<int> TargetLane = new List<int>();
    public int Seed;
    public readonly List<int> Order = new List<int>();
    public bool IsFallback;
    public readonly List<bool> HasDecoy = new List<bool>();
    public int RouteIndex;
    public int _0xf939b1f6
    {
        get
        {
            return this.TargetLane.Count;
        }
    }
}