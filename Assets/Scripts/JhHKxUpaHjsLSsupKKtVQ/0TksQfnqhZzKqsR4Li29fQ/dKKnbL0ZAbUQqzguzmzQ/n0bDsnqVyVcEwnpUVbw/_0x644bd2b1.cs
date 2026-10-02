using UnityEngine;
using UnityEngine.UI;

public class _0x644bd2b1 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0x58fa003f == null)
            if (!this.TryGetComponent(out this._0x58fa003f))
                this._0x58fa003f = this.GetComponentInChildren<Button>();
    }

    private Button _0x58fa003f;
    private void Start()
    {
        if (this._0x7ad13c1d)
            this._0x58fa003f.onClick.AddListener(() => _0x57de1605.Instance._0xbb4a065d());
        else
            this._0x58fa003f.onClick.AddListener(() => _0x57de1605.Instance._0x6df0561b(this._0x7a44ebab));
    }

    private int _0x7a44ebab;
    private bool _0x7ad13c1d;
}