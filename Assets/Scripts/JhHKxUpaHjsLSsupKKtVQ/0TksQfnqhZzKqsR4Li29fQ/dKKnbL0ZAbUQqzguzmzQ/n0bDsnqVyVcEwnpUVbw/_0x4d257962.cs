using UnityEngine;
using UnityEngine.UI;

public class _0x4d257962 : MonoBehaviour
{
    public bool IsShowLastPop;
    public Button Button;
    public bool IsHideAllPops;
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x6a657270.Instance._0x521d3a0d();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x6a657270.Instance._0x42a33b89());
        else
            this.Button.onClick.AddListener(() => _0x6a657270.Instance._0xc691f984(this.PopToShowIndex));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}