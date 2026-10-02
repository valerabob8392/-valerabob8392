using UnityEngine;
using UnityEngine.UI;

public class _0x7b5794db : MonoBehaviour
{
    public bool IsTutorialEndPanel;
    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x57de1605.Instance._0x6df0561b(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x847661bf.Instance._0x2ce51a91());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x57de1605.Instance._0x6df0561b(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x57de1605.Instance._0x6df0561b(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x847661bf.Instance._0x2ce51a91());
        }
    }

    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
}