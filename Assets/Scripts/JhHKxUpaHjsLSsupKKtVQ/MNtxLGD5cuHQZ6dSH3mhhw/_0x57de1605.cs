using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb7a79f4e;

public class _0x57de1605 : MonoBehaviour
{
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public int CurrentPanelIndex;
    public void _0xeae7915e(int _0xc98f99f3)
    {
        if (_0xc98f99f3 == _0x4a0666d8.SPLASH && _0x847661bf.Instance._0xd7f71150 != _0x0972bb08.SCENE_0)
            _0x5d442966.Instance._0x9faabd7d();
        if (_0x847661bf.Instance._0xd7f71150 != _0x0972bb08.SCENE_0)
        {
            if (_0xc98f99f3 == _0x4a0666d8.SPLASH || _0xc98f99f3 == _0x4a0666d8.TUTORIAL0)
                _0x847661bf.Instance._0x6c61b7ff(false);
            else if (_0xc98f99f3 == _0x4a0666d8.DEFAULT)
                _0x847661bf.Instance._0x6c61b7ff(true);
        }
    }

    private void SwitchSplash()
    {
        if (_0xdaf7e66c.Instance.IsTutorialEnabled && !_0x847661bf._0x371d8914._0x91847af7)
            this._0x6df0561b(_0x4a0666d8.TUTORIAL0);
        else
            this._0x6df0561b(_0x4a0666d8.DEFAULT);
    }

    public List<_0x3dafaafe> Panels;
    private void _0x4b4c9c16(int _0x21ec455e)
    {
        this._0x9481f6e0(_0x21ec455e);
        this._0x003f7040(_0x21ec455e);
        this.CurrentPanelIndex = _0x21ec455e;
        this.Panels[_0x21ec455e]._0x253ea74a();
    }

    private void _0x003f7040(int _0xdd6973b5)
    {
        if (_0xdd6973b5 == _0x4a0666d8.SPLASH)
            _0x5d442966.Instance._0xa37e3a25();
        if (_0x847661bf.Instance._0xd7f71150 == _0x0972bb08.SCENE_0)
        {
        }
    }

    public float StaticBlurMaterialInitialValue;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x57de1605>();
    }

    private void _0x9481f6e0(int _0xaa609a22)
    {
        this.LastPanelIndexes.Add(_0xaa609a22);
        this.CurrentPanelIndex = _0xaa609a22;
        for (int _0xcca3d527 = 0; _0xcca3d527 < this.Panels.Count; _0xcca3d527++)
            if (_0xcca3d527 != _0xaa609a22 && this.Panels[_0xcca3d527] != null)
                this.Panels[_0xcca3d527]._0x79a03835();
    }

    public void _0xbb4a065d()
    {
        this.LastPanelIndexes.RemoveAll(_0x34fbbce8 => _0x34fbbce8 == this.CurrentPanelIndex);
        int _0x058cb074 = this.LastPanelIndexes.Last();
        this._0x003f7040(_0x058cb074);
        this._0x7188ae5b(_0x058cb074);
        this.CurrentPanelIndex = _0x058cb074;
        this.Panels[_0x058cb074].Show();
    }

    public static _0x57de1605 Instance;
    public float ScaleDuration = 0.4f;
    public bool IsShowSplashOnStart = true;
    private void _0x7188ae5b(int _0xc724e531)
    {
        this.LastPanelIndexes.Add(_0xc724e531);
        this.CurrentPanelIndex = _0xc724e531;
        for (int _0x6b9fd5fa = 0; _0x6b9fd5fa < this.Panels.Count; _0x6b9fd5fa++)
            if (_0x6b9fd5fa != _0xc724e531 && this.Panels[_0x6b9fd5fa] != null)
                this.Panels[_0x6b9fd5fa]._0x79a03835();
    }

    private void Start()
    {
        this._0x3f6c14c6();
    }

    private _0x3dafaafe _0x737d2f1f(int _0xe6ee3687)
    {
        return this.Panels[_0xe6ee3687];
    }

    public void _0x6df0561b(int _0xb89ffd6f)
    {
        this._0x9481f6e0(_0xb89ffd6f);
        this._0x003f7040(_0xb89ffd6f);
        this.CurrentPanelIndex = _0xb89ffd6f;
        this.Panels[_0xb89ffd6f].Show();
    }

    private void _0x3f6c14c6()
    {
        this._0x4b4c9c16(_0x4a0666d8.SPLASH);
        if (_0x847661bf.Instance._0xd7f71150 == _0x0972bb08.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x5d442966.Instance.DefaultAnimationTime);
        }
    }
}