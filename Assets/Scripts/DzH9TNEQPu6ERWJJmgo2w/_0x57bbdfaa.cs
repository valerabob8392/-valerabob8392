using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x57bbdfaa : MonoBehaviour
{
    private static float Linear(float _0x79417fe2)
    {
        _0x79417fe2 = Mathf.Clamp01(_0x79417fe2);
        return _0x79417fe2 <= 0.03928f ? _0x79417fe2 / 12.92f : Mathf.Pow((_0x79417fe2 + 0.055f) / 1.055f, 2.4f);
    }

    private static void Fix(TMP_Text _0x2cd4daee)
    {
        if (_0x2cd4daee == null || !_0x2cd4daee.isActiveAndEnabled)
            return;
        Material _0xe9238bca = _0x2cd4daee.fontSharedMaterial;
        if (_0xe9238bca == null || !_0xe9238bca.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xe9238bca.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xe9238bca.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x30dbd2b2 = _0x2cd4daee.color;
        if (_0x30dbd2b2.a <= 0f)
            return;
        Color _0x13e090bb = _0xe9238bca.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x30dbd2b2, _0x13e090bb) >= MinRatio)
            return;
        Color _0xc295eaab = Luminance(_0x13e090bb) < 0.5f ? Color.white : Color.black;
        Color _0xfe286325;
        if (Ratio(_0xc295eaab, _0x13e090bb) < TargetRatio)
        {
            _0xfe286325 = _0xc295eaab;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xe4ee3959 = 0f;
            float _0xa5c577d7 = 1f;
            for (int _0x710fb163 = 0; _0x710fb163 < 20; _0x710fb163++)
            {
                float _0x0e6b9c68 = (_0xe4ee3959 + _0xa5c577d7) * 0.5f;
                if (Ratio(Color.Lerp(_0x30dbd2b2, _0xc295eaab, _0x0e6b9c68), _0x13e090bb) >= TargetRatio)
                    _0xa5c577d7 = _0x0e6b9c68;
                else
                    _0xe4ee3959 = _0x0e6b9c68;
            }

            _0xfe286325 = Color.Lerp(_0x30dbd2b2, _0xc295eaab, _0xa5c577d7);
        }

        _0xfe286325.a = _0x30dbd2b2.a;
        _0x2cd4daee.color = _0xfe286325;
    }

    private static _0x57bbdfaa _0x0b8cdd56;
    private const float TargetRatio = 7f;
    private const float MinOutlineWidth = 0.01f;
    private void OnDisable()
    {
        if (this._0x7d7dc1e1 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x7d7dc1e1);
    }

    private void OnEnable()
    {
        if (this._0x7d7dc1e1 == null)
            this._0x7d7dc1e1 = _0x2d6f45f9 => this._0x74a963e5(_0x2d6f45f9);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x7d7dc1e1);
    }

    private void LateUpdate()
    {
        if (this._0x7b119be9.Count == 0)
            return;
        this._0x05aeaf0a.Clear();
        this._0x05aeaf0a.AddRange(this._0x7b119be9);
        this._0x7b119be9.Clear();
        for (int _0x604747b9 = 0; _0x604747b9 < this._0x05aeaf0a.Count; _0x604747b9++)
            Fix(this._0x05aeaf0a[_0x604747b9]);
    }

    private readonly HashSet<TMP_Text> _0x7b119be9 = new HashSet<TMP_Text>();
    private const float MinRatio = 4.5f;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xa2cde71e)
    {
        return 0.2126f * Linear(_0xa2cde71e.r) + 0.7152f * Linear(_0xa2cde71e.g) + 0.0722f * Linear(_0xa2cde71e.b);
    }

    private static float Ratio(Color _0x95bdee35, Color _0x8470e4a8)
    {
        float _0x9d4f4949 = Luminance(_0x95bdee35);
        float _0x9e2c6d5a = Luminance(_0x8470e4a8);
        return (Mathf.Max(_0x9d4f4949, _0x9e2c6d5a) + 0.05f) / (Mathf.Min(_0x9d4f4949, _0x9e2c6d5a) + 0.05f);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x74a963e5(Object _0x9d21724f)
    {
        TMP_Text _0xb3168fc1 = _0x9d21724f as TMP_Text;
        if (_0xb3168fc1 != null)
            this._0x7b119be9.Add(_0xb3168fc1);
    }

    private readonly List<TMP_Text> _0x05aeaf0a = new List<TMP_Text>();
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x0b8cdd56 != null)
            return;
        GameObject _0x7151703a = new GameObject(_0xc4745104._0xf88ed958(new byte[16] { 141, 180, 169, 154, 182, 183, 173, 171, 184, 170, 173, 158, 172, 184, 171, 189 }, 217));
        _0x7151703a.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x7151703a);
        _0x0b8cdd56 = _0x7151703a.AddComponent<_0x57bbdfaa>();
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x7d7dc1e1;
}

internal static class _0xc4745104
{
    internal static string _0xf88ed958(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}