using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x5d442966 : MonoBehaviour
{
    public void _0xa37e3a25()
    {
        this._0xe70ba722?.Kill();
        this.AnimationSlider.value = _0xc30f43c6 ? this.SecondPassSliderValue : 0.05f;
    }

    private Sequence _0xe70ba722;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x5d442966>();
    }

    private static bool _0xc30f43c6 = false;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xb7a79f4e._0x0972bb08.SCENE_0 && !_0xc30f43c6)
        {
            this._0x75352629();
        }
        else
        {
            this._0x9faabd7d();
        }
    }

    public void _0xe0c21a20()
    {
        this._0xe70ba722?.Play();
    }

    private void _0x75352629()
    {
        this.AnimationSlider.value = 0.05f;
        _0xc30f43c6 = !_0xc30f43c6;
        this._0xe70ba722 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x4825c928 => this.AnimationSlider.value = _0x4825c928, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x9e5d6783._0xd86bed44?._0x4d4b972e();
        });
    }

    public void _0x9faabd7d()
    {
        this._0xa37e3a25();
        bool _0x3b9a306b = _0xc30f43c6;
        this._0xe70ba722 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x4825c928 => this.AnimationSlider.value = _0x4825c928, _0x3b9a306b ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xc30f43c6 = !_0xc30f43c6;
    }

    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
    public void _0xfdfc9290()
    {
        this._0xe70ba722?.Pause();
    }

    public GameObject Background;
    public float FirstAnimationTime = 10.0f;
    public GameObject Error;
    public static _0x5d442966 Instance;
    public Slider AnimationSlider;
    public GameObject Content;
    public void _0x1fb096c3()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xe70ba722?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xc30f43c6 = false;
    }
}