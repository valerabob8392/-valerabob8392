using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xb7a79f4e;

public class _0x6a657270 : MonoBehaviour
{
    private void _0x1273fe17()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    private void _0xd56624a9()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public float ScaleDuration = 0.4f;
    public List<int> LastPopIndexes = new();
    public static _0x6a657270 Instance;
    public void _0x42a33b89()
    {
        this.LastPopIndexes.Clear();
        this._0x9cc66085();
        foreach (GameObject _0x5fc72d1f in this.GameObjectsToHide)
            if (_0x5fc72d1f != null)
                _0x5fc72d1f.SetActive(true);
        this._0xd56624a9();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public GameObject BlurBackground;
    public void _0xc691f984(int _0x94d1f67e)
    {
        this.CurrentPopIndex = _0x94d1f67e;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x9cc66085(true);
        this._0x1273fe17();
        this.Pops[_0x94d1f67e].Show();
        foreach (GameObject _0x3f07ef2e in this.GameObjectsToHide)
            _0x3f07ef2e.SetActive(false);
    }

    public List<_0xc36ede33> Pops;
    private void _0x9cc66085(bool _0xc6821144 = false)
    {
        for (int _0x0d5085a4 = 0; _0x0d5085a4 < this.Pops.Count; ++_0x0d5085a4)
            if (this.Pops[_0x0d5085a4] != null && !(_0x0d5085a4 == this.CurrentPopIndex && _0xc6821144))
                this.Pops[_0x0d5085a4]._0xfbd68b93();
    }

    public List<GameObject> GameObjectsToHide;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6a657270>();
    }

    public _0xc36ede33 _0xb23a01fe(int _0x7d36ced3)
    {
        return this.Pops[_0x7d36ced3];
    }

    public int CurrentPopIndex;
    public void _0x521d3a0d()
    {
        this.LastPopIndexes.RemoveAll(_0x34fbbce8 => _0x34fbbce8 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x42a33b89();
        else
            this._0xc691f984(this.LastPopIndexes.Last());
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xc36ede33 _0x909d3223 in this.Pops)
            if (_0x909d3223 != null)
                _0x909d3223.gameObject.SetActive(true);
    }
}