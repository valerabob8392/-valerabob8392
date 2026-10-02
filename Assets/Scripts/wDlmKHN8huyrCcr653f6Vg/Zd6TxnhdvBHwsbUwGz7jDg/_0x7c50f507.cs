using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x7c50f507 : MonoBehaviour
{
    private Vector3 _0xf9fb0d82 { get; set; }
    private float _0xf8bcd52d { get; set; }
    private Vector3 _0x7c5dfada { get; set; }
    private Vector3 _0x1e0398e2 { get; set; }

    private void Awake()
    {
        this._0x263d5904 = this.GetComponent<Camera>();
        _0x8f0271a6 = this;
        this._0x4158724b();
    }

    private Vector3 _0xd91e8d16 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x756d5312;
        Matrix4x4 _0xc9f026a5 = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x263d5904.orthographic)
        {
            float _0xcb6dfab8 = this._0x263d5904.farClipPlane - this._0x263d5904.nearClipPlane;
            float _0x4ffb1cd4 = (this._0x263d5904.farClipPlane + this._0x263d5904.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x4ffb1cd4), new Vector3(this._0x263d5904.orthographicSize * 2 * this._0x263d5904.aspect, this._0x263d5904.orthographicSize * 2, _0xcb6dfab8));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x263d5904.fieldOfView, this._0x263d5904.farClipPlane, this._0x263d5904.nearClipPlane, this._0x263d5904.aspect);
        }

        Gizmos.matrix = _0xc9f026a5;
    }

    public enum _0xb9d099d4
    {
        Landscape,
        Portrait
    }

    private _0xb9d099d4 _0x881f59ba = _0xb9d099d4.Portrait;
    private static _0x7c50f507 _0x8f0271a6;
    private Vector3 _0x620ad1e1 { get; set; }
    private Vector3 _0x3bd1b5fa { get; set; }

    private Color _0x756d5312 = Color.white;
    private float _0x0a77ad5d = 1;
    private Vector3 _0xe04dcbb9 { get; set; }
    private Vector3 _0xa9548779 { get; set; }
    private Vector3 _0x0dfb9e96 { get; set; }

    private new Camera _0x263d5904;
    private void _0x4158724b()
    {
        float _0x04b9818b, _0xc9dd9c2a, _0x70533ec9, _0x555bab83;
        if (this._0x881f59ba == _0xb9d099d4.Landscape)
            this._0x263d5904.orthographicSize = 1f / this._0x263d5904.aspect * this._0x0a77ad5d / 2f;
        else
            this._0x263d5904.orthographicSize = this._0x0a77ad5d / 2f;
        this._0xf8bcd52d = 2f * this._0x263d5904.orthographicSize;
        this._0xa622028e = this._0xf8bcd52d * this._0x263d5904.aspect;
        float _0x04749c9e = this._0x263d5904.transform.position.x;
        float _0x0d918942 = this._0x263d5904.transform.position.y;
        _0x04b9818b = _0x04749c9e - this._0xa622028e / 2;
        _0xc9dd9c2a = _0x04749c9e + this._0xa622028e / 2;
        _0x70533ec9 = _0x0d918942 + this._0xf8bcd52d / 2;
        _0x555bab83 = _0x0d918942 - this._0xf8bcd52d / 2;
        this._0x620ad1e1 = new Vector3(_0x04b9818b, _0x555bab83, 0);
        this._0xd91e8d16 = new Vector3(_0x04749c9e, _0x555bab83, 0);
        this._0x7c5dfada = new Vector3(_0xc9dd9c2a, _0x555bab83, 0);
        this._0xf9fb0d82 = new Vector3(_0x04b9818b, _0x0d918942, 0);
        this._0x1e0398e2 = new Vector3(_0x04749c9e, _0x0d918942, 0);
        this._0x3bd1b5fa = new Vector3(_0xc9dd9c2a, _0x0d918942, 0);
        this._0x0dfb9e96 = new Vector3(_0x04b9818b, _0x70533ec9, 0);
        this._0xe04dcbb9 = new Vector3(_0x04749c9e, _0x70533ec9, 0);
        this._0xa9548779 = new Vector3(_0xc9dd9c2a, _0x70533ec9, 0);
    }

    //public bool executeInUpdate;
    private float _0xa622028e { get; set; }
}