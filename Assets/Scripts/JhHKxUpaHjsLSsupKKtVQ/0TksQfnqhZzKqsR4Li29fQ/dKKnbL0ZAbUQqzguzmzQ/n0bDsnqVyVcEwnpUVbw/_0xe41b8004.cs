using UnityEngine;
using UnityEngine.UI;

public class _0xe41b8004 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x847661bf.Instance._0x6c61b7ff(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}