using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xb7a79f4e;

public class _0x847661bf : MonoBehaviour
{
    private void Start()
    {
        if (this._0xd7f71150 != _0x0972bb08.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x0972bb08.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x371d8914._0x91847af7 = false;
            _0x6a657270.Instance._0x42a33b89();
            _0x57de1605.Instance._0x6df0561b(_0x4a0666d8.TUTORIAL0);
        });
    }

    public static bool IsAfterLevelFailed = false;
    public Canvas MainCanvas;
    public void _0x2ce51a91()
    {
        _0x371d8914._0x91847af7 = true;
    }

    public int _0xd7f71150 => SceneManager.GetActiveScene().buildIndex;

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static _0x847661bf Instance;
    [HideInInspector]
    public List<_0xb171ab20> MoneyCountContainers = new();
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0x0f1cd2d6()
    {
        foreach (_0xb171ab20 _0x941a6b93 in this.MoneyCountContainers)
            _0x941a6b93._0x0cd2c731();
    }

    public Button ShowResetTutorialButton;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x847661bf>();
        this.RootGameObject = GameObject.FindWithTag(_0xca438dac._0xdf9daece(new byte[4] { 233, 212, 212, 207 }, 187));
        if (this._0xd7f71150 == _0x0972bb08.SCENE_0)
            this._0x6c61b7ff(true);
        else
            this._0x6c61b7ff(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xb171ab20>(true).ToList();
    }

    public void _0x6c61b7ff(bool _0xf7b654e9)
    {
        this._0xc5443ffc = _0xf7b654e9;
        this._0x8dedfff0(!this._0xc5443ffc);
        Physics2D.simulationMode = this._0xc5443ffc ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x1c53c09d(this.EnvironmentWithTweensToToggle);
    }

    public Transform Environment;
    public void LoadSceneByIndex(int _0xd1ff0ed0)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xd7087854(_0xd1ff0ed0));
    }

    private void _0x1c53c09d(Transform _0x25a1b9b4)
    {
        Transform[] _0xa3727f3b = _0x25a1b9b4.GetComponentsInChildren<Transform>();
        foreach (Transform _0xd1080d37 in _0xa3727f3b)
            if (_0xd1080d37 != null && DOTween.IsTweening(_0xd1080d37))
            {
                if (this._0xc5443ffc)
                    DOTween.Play(_0xd1080d37);
                else
                    DOTween.Pause(_0xd1080d37);
            }
    }

    private static _0x59a34464 _0x9b91d3db => _0x59a34464.ALL_SCENES_SETTING_SINGLETONS[0];

    public Transform EnvironmentWithTweensToToggle;
    private static _0x59a34464 GAME_INDEX_SETTINGS(int _0xeac921ae)
    {
        return _0x59a34464.ALL_SCENES_SETTING_SINGLETONS[_0xeac921ae];
    }

    public bool _0xc5443ffc { get; private set; }

    public void _0xbc2756d5()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    private static void MakeGrid(List<RectTransform> _0x0d0ca913, AspectRatioFitter _0x6335beb2, float _0x0ee5b1f1, int _0x886deabd, int _0xcebde600)
    {
        _0x6335beb2.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x6335beb2.aspectRatio = _0x0ee5b1f1;
        foreach (RectTransform _0x87048346 in _0x0d0ca913)
        {
            int _0x28437d28 = _0x87048346.transform.GetSiblingIndex();
            _0x87048346.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x28437d28 % _0x886deabd) * (1f / _0x886deabd), (_0xcebde600 - (Mathf.FloorToInt((float)_0x28437d28 / _0x886deabd) % _0xcebde600 + 1f)) * (1f / _0xcebde600));
            _0x87048346.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x28437d28 % _0x886deabd + 1f) * (1f / _0x886deabd), (_0xcebde600 - Mathf.FloorToInt((float)_0x28437d28 / _0x886deabd) % _0xcebde600) * (1f / _0xcebde600));
            _0x87048346.offsetMin = Vector2.zero;
            _0x87048346.offsetMax = Vector2.zero;
        }
    }

    private void _0xfc722381()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x0972bb08.SCENE_0);
    }

    public static bool IsAfterLevelComplete;
    public static _0x59a34464 _0x371d8914 => _0x59a34464.ALL_SCENES_SETTING_SINGLETONS[Instance._0xd7f71150];

    private IEnumerator _0xd7087854(int _0xcd43a243)
    {
        _0x57de1605.Instance._0x6df0561b(_0x4a0666d8.SPLASH);
        AsyncOperation _0x9e4684b7 = SceneManager.LoadSceneAsync(_0xcd43a243);
        while (!_0x9e4684b7.isDone)
            yield return null;
    }

    private void _0x8dedfff0(bool _0xc28068e0)
    {
        Rigidbody2D[] _0x605c75bc = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x33d49a7d in _0x605c75bc)
            if (_0xc28068e0)
                _0x33d49a7d.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x33d49a7d.constraints = RigidbodyConstraints2D.None;
    }

    public Button DeleteProgressDataButton;
    private IEnumerator _0xeb56a41c(string _0x44d3f04a)
    {
        _0x57de1605.Instance._0x6df0561b(_0x4a0666d8.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0xca80f550 = SceneManager.LoadSceneAsync(_0x44d3f04a);
        while (!_0xca80f550.isDone)
            yield return null;
    }
}

internal static class _0xca438dac
{
    internal static string _0xdf9daece(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}