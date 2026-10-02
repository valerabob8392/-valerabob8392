using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xa565435e : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x847661bf.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x847661bf.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    public Button Button;
}