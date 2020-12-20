using UnityEngine;

public class Car : MonoBehaviour
{
    /*
    [Header("這汽車的高度")]
    [Range(3,5)]
    public int height = 5;

    [Tooltip("汽車的重量以噸計算"),Range(0.1f,50.0f)]
    public float weight = 5.5f;

    [Header("這汽車的品牌")]
    public string brand = "BMW";
    
    [Header("這汽車是否有天窗")]
    public bool haswindow = true;

    public Color mycolor1;
    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color mycolor2 = new Color();

    public Vector2 way0 = Vector2.zero;
    public Vector3 way1 = Vector3.one;

    public Sprite pic;*/

    [Header("移動速度"),Range(0.0f,1000.0f)]
    public float speed = 10.5f;

    [Header("跳要高度"), Range(0, 300)]
    public int high = 100;




}