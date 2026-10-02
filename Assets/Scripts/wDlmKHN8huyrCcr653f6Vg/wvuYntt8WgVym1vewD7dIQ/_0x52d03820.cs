using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x52d03820 : MonoBehaviour
{
    private void Update()
    {
        int _0x5cdc0d6a = 1;
        if (this._0x596ce9b9.Count > 0)
        {
            string _0x57dc0e16 = this._0xe532d101.text;
            foreach (string _0x796847e6 in this._0x596ce9b9)
                while (_0x57dc0e16.Contains(_0x796847e6))
                    _0x57dc0e16 = _0x57dc0e16.Replace(_0x796847e6, "");
            _0x5cdc0d6a = _0x57dc0e16.Length;
        }
        else
        {
            _0x5cdc0d6a = this._0xe532d101.text.Length;
        }

        float _0xda140e1a = Mathf.Clamp(this._0xa5180458 + this._0xc9b86ecf * _0x5cdc0d6a, this._0xd0896768, this._0xb96e8c30);
        if (!Mathf.Approximately(this._0xf7f2f60f.aspectRatio, _0xda140e1a))
            this._0xf7f2f60f.aspectRatio = _0xda140e1a;
    }

    private float _0xd0896768 = 1.5f;
    private AspectRatioFitter _0xf7f2f60f;
    private List<string> _0x596ce9b9 = new();
    private TMP_Text _0xe532d101;
    private float _0xb96e8c30 = 4;
    private float _0xa5180458;
    private float _0xc9b86ecf = 0.6f;
}