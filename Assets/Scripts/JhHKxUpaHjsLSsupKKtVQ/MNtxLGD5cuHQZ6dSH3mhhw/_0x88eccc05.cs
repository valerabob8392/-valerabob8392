using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x88eccc05 : MonoBehaviour
{
    public void _0xf88b0afa(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x396b1e7d();
            this._0x2b7119d0();
        }
    }

    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    private void _0x2b7119d0()
    {
        if (this.ScoreCurrent > _0x847661bf._0x371d8914._0x34cd07ba)
            _0x847661bf._0x371d8914._0x34cd07ba = this.ScoreCurrent;
        if (_0xdaf7e66c.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x96c5e013)
                this._0x316fd8d3();
    }

    public int CustomTimeInitial = 30;
    private int _0xcfe9e1bc => this.CustomTimeInitial + _0x847661bf._0x371d8914._0x42e163d3 * 10;

    private static _0x88eccc05 _0x825d22ce;
    private void Awake()
    {
        _0x825d22ce = this.gameObject.GetComponent<_0x88eccc05>();
    }

    private IEnumerator _0x5cff2dd5()
    {
        this._0x04c3a745();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x847661bf.Instance._0xd7f71150 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x847661bf.Instance._0xc5443ffc)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x04c3a745();
            }
        }

        if (!this.IsGameEnd)
            this._0xfc4f46e3();
    }

    public List<TMP_Text> ScoreText = new();
    private int _0x96c5e013 => this.CustomTargetScore + _0x847661bf._0x371d8914._0x42e163d3 * 10;

    private void _0x396b1e7d()
    {
        if (_0xdaf7e66c.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xea6f0108 => _0xea6f0108.text = $"{this.ScoreCurrent}/{this._0x96c5e013}");
        else
            this.ScoreText.ForEach(_0xea6f0108 => _0xea6f0108.text = $"{this.ScoreCurrent}");
    }

    public void _0x316fd8d3()
    {
        if (!this.IsGameEnd)
        {
            this._0xfb93fcf0();
            _0x847661bf.IsAfterLevelComplete = true;
            _0x847661bf.IsAfterLevelFailed = false;
            _0xc36ede33 _0xe431a2cf = _0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.WIN).GetComponent<_0xc36ede33>();
            if (_0xdaf7e66c.Instance.IsCheckScoreEnabled)
                _0xe431a2cf.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x96c5e013}";
            else
                _0xe431a2cf.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xdaf7e66c.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xb7a79f4e._0x53a33f42._0x81b0b0cd)
                    _0xb7a79f4e._0x53a33f42._0x81b0b0cd = this.ScoreCurrent;
                _0xe431a2cf.ContentAdditionalText.text = $"{_0xb7a79f4e._0x53a33f42._0x81b0b0cd}";
            }
            else
            {
                _0xe431a2cf.ContentAdditionalText.text = $"{this._0xc645b834}";
                _0xb7a79f4e._0x53a33f42._0x81b0b0cd += this._0xc645b834;
            }

            if (_0xdaf7e66c.Instance.IsLevelIncrementOnWin)
                ++_0x847661bf._0x371d8914._0x42e163d3;
            _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.WIN);
        }
    }

    private void _0x04c3a745()
    {
        this.TimerText.ForEach(_0xea6f0108 => _0xea6f0108.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x3c386bf4._0x46f47019(new byte[6] { 27, 27, 42, 76, 5, 5 }, 118)));
    }

    public List<TMP_Text> LevelNumberText = new();
    public List<TMP_Text> SubtitleText = new();
    public void _0xfb505f01()
    {
        _0x847661bf.Instance._0x6c61b7ff(true);
        _0x847661bf.Instance.LoadSceneByIndex(_0xb7a79f4e._0x0972bb08.SCENE_0);
    }

    private void _0x51bff853()
    {
        if (this.ScoreCurrent >= this._0x96c5e013)
            this._0x316fd8d3();
        else
            this._0xfc4f46e3();
    }

    private int _0xc645b834 => this.ScoreCurrent;

    public int CustomTargetScore = 10;
    [HideInInspector]
    public int ScoreCurrent;
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xcfe9e1bc;
        this.CurrentGameIndex = _0x847661bf.Instance._0xd7f71150;
        foreach (Button _0x2f27b7f4 in this.HomeButtons)
            _0x2f27b7f4.onClick.AddListener(() =>
            {
                this._0xfb505f01();
            });
        foreach (Button _0x666db43f in this.PauseButtons)
            _0x666db43f.onClick.AddListener(() =>
            {
                _0x847661bf.Instance._0x6c61b7ff(false);
                _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.PAUSE);
            });
        this._0x396b1e7d();
        this.LevelNumberText.ForEach(_0xea6f0108 => _0xea6f0108.text = $"LVL {_0x847661bf._0x371d8914._0x42e163d3 + 1}");
        if (_0xdaf7e66c.Instance.IsTimerEnabled)
        {
            this._0x04c3a745();
            this.StartCoroutine(this._0x5cff2dd5());
        }
    }

    private void _0xfb93fcf0()
    {
        this.IsGameEnd = true;
        _0x847661bf.IsAfterLevelComplete = true;
    }

    public List<Button> PauseButtons = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public int TimeLeft;
    public void _0xfc4f46e3()
    {
        if (_0xdaf7e66c.Instance.IsOnlyWinGameEndEnabled)
            this._0x316fd8d3();
        if (!this.IsGameEnd)
        {
            this._0xfb93fcf0();
            _0x847661bf.IsAfterLevelComplete = false;
            _0x847661bf.IsAfterLevelFailed = true;
            _0xc36ede33 _0x7e30006f = _0x6a657270.Instance._0xb23a01fe(_0xb7a79f4e._0x3d74e9c5.LOSE).GetComponent<_0xc36ede33>();
            if (_0xdaf7e66c.Instance.IsCheckScoreEnabled)
                _0x7e30006f.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x96c5e013}";
            else
                _0x7e30006f.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x7e30006f.ContentAdditionalText.text = $"{0}";
            _0xb7a79f4e._0x53a33f42._0x81b0b0cd += 0;
            _0x6a657270.Instance._0xc691f984(_0xb7a79f4e._0x3d74e9c5.LOSE);
        }
    }
}

internal static class _0x3c386bf4
{
    internal static string _0x46f47019(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}