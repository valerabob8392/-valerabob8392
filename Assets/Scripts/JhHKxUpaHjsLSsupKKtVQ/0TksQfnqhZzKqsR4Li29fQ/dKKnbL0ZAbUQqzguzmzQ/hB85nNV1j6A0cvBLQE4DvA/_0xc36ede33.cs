using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xc36ede33 : MonoBehaviour
{
    public bool IsOnlyYScale;
    public static void HideAllPops()
    {
        _0x6a657270.Instance._0x42a33b89();
    }

    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public Image ContentImage;
    private void _0xb5fe9d80()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xb5fe9d80();
    }

    private bool _0xea2ecf82 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public TMP_Text ContentMainText;
    public void _0xfbd68b93()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Ease ease = Ease.OutSine;
    public TMP_Text ContentHeaderText;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentAdditionalText;
    public float scaleDuration = 0.4f;
}