using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x3dafaafe : MonoBehaviour
{
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x8caf6652();
    }

    public GameObject OuterBackground;
    public float ScaleDuration = 0.4f;
    public TMP_Text HeaderText;
    public void _0x253ea74a()
    {
        this._0x7f86acf1();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x57de1605.Instance._0xeae7915e(_0x57de1605.Instance.CurrentPanelIndex);
    }

    public void Show()
    {
        this._0xce317ac4();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x57de1605.Instance._0xeae7915e(_0x57de1605.Instance.CurrentPanelIndex);
            });
        }
    }

    private bool _0x3ee4911e => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public GameObject Content;
    public TMP_Text MainText;
    private void _0x33f8ec43()
    {
        if (this.OuterBackground != null)
        {
            Image _0xbf405424 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xbf405424, true);
            _0xbf405424.DOFade(0f, this.ScaleDuration);
        }
    }

    private void _0x7f86acf1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x02ef9cd2 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x02ef9cd2, true);
            _0x02ef9cd2.DOFade(1f, 0f);
        }
    }

    public void _0x79a03835()
    {
        this._0x33f8ec43();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public Ease Ease = Ease.OutSine;
    private void _0x8caf6652()
    {
        if (this.OuterBackground != null)
        {
            Image _0x05bb81b4 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x05bb81b4, true);
            _0x05bb81b4.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public bool IsScaledDownOnAwake = true;
    private void _0xce317ac4()
    {
        if (this.OuterBackground != null)
        {
            Image _0x54d45e0d = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x54d45e0d, true);
            _0x54d45e0d.DOFade(1f, this.ScaleDuration / 2f);
        }
    }
}