using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9b989883 : MonoBehaviour
{
    private void _0x1960f852()
    {
        if (this._0xcbc0824f.canvasRenderer.GetColor() != this._0xec760818.canvasRenderer.GetColor())
            this._0xec760818.canvasRenderer.SetColor(this._0xcbc0824f.canvasRenderer.GetColor());
    }

    private TMP_Text _0xec760818;
    private void Update()
    {
        this._0x1960f852();
    }

    private Image _0xcbc0824f;
}