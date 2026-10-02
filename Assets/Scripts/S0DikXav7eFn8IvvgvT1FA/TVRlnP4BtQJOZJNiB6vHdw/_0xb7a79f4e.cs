using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xb7a79f4e
{
    public static class _0x0972bb08
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x59a34464
    {
        private static readonly _0x59a34464 _0x6d8b9f79 = new();
        public static readonly _0x59a34464[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x6d8b9f79,
            _0x6d8b9f79,
            _0x6d8b9f79,
        };
        private int _0x76339332 => 0;
        private int _0xfb1d2f81 => 10;
        private string _0xe6afe67b => _0x42a99a02._0xf8a895e7(new byte[4] { 235, 195, 200, 211 }, 166);
        private string _0x5d52c174 => _0x42a99a02._0xf8a895e7(new byte[8] { 231, 238, 253, 238, 231, 208, 155, 214 }, 171);

        private int _0x9571674f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x42a99a02._0xf8a895e7(new byte[25] { 118, 64, 71, 71, 80, 91, 65, 114, 89, 90, 87, 84, 89, 118, 93, 84, 69, 65, 80, 71, 124, 91, 81, 80, 77 }, 53)))
                    PlayerPrefs.SetInt(_0x42a99a02._0xf8a895e7(new byte[25] { 214, 224, 231, 231, 240, 251, 225, 210, 249, 250, 247, 244, 249, 214, 253, 244, 229, 225, 240, 231, 220, 251, 241, 240, 237 }, 149), 0);
                return PlayerPrefs.GetInt(_0x42a99a02._0xf8a895e7(new byte[25] { 160, 150, 145, 145, 134, 141, 151, 164, 143, 140, 129, 130, 143, 160, 139, 130, 147, 151, 134, 145, 170, 141, 135, 134, 155 }, 227));
            }

            set => PlayerPrefs.SetInt(_0x42a99a02._0xf8a895e7(new byte[25] { 133, 179, 180, 180, 163, 168, 178, 129, 170, 169, 164, 167, 170, 133, 174, 167, 182, 178, 163, 180, 143, 168, 162, 163, 190 }, 198), value);
        }

        public int _0x42e163d3
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe6afe67b}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xe6afe67b}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xe6afe67b}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xe6afe67b}CurrentLevelIndex", value);
        }

        public int _0x34cd07ba
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe6afe67b}BestScore"))
                    this._0x34cd07ba = 0;
                return PlayerPrefs.GetInt($"{this._0xe6afe67b}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xe6afe67b}BestScore", value);
        }

        public bool _0x91847af7
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xe6afe67b}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xe6afe67b}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xe6afe67b}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xe6afe67b}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x53a33f42
    {
        public static int _0x81b0b0cd
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x42a99a02._0xf8a895e7(new byte[5] { 95, 115, 117, 114, 111 }, 28)))
                    PlayerPrefs.SetInt(_0x42a99a02._0xf8a895e7(new byte[5] { 205, 225, 231, 224, 253 }, 142), 0);
                return PlayerPrefs.GetInt(_0x42a99a02._0xf8a895e7(new byte[5] { 74, 102, 96, 103, 122 }, 9));
            }

            set
            {
                PlayerPrefs.SetInt(_0x42a99a02._0xf8a895e7(new byte[5] { 199, 235, 237, 234, 247 }, 132), value);
                _0x847661bf.Instance._0x0f1cd2d6();
            }
        }
    }

    public static class _0x3d74e9c5
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x4a0666d8
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x42a99a02
{
    internal static string _0xf8a895e7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}