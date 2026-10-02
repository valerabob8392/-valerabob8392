using TMPro;
using UnityEngine;
using static _0xb7a79f4e;

public class _0xb171ab20 : MonoBehaviour
{
    public void _0x0cd2c731()
    {
        this.MoneyCountText.text = _0x53a33f42._0x81b0b0cd.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x165bd937;
            if (this.gameObject.TryGetComponent(out _0x165bd937))
                this.MoneyCountText = _0x165bd937;
        }

        this._0x0cd2c731();
    }

    public TMP_Text MoneyCountText;
}