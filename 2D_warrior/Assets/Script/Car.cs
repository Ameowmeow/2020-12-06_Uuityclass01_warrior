using UnityEngine;

public class Car : MonoBehaviour
{
    #region 區塊練習

    [Header("這汽車的高度")]
    [Range(3,5)]
    public int height = 5;

    [Tooltip("汽車的重量以噸計算"),Range(0.1f,50.0f)]
    public float weight = 10.5f;

    [Header("這汽車的品牌")]
    public string brand = "BMW";
    
    [Header("這汽車是否有天窗")]
    public bool haswindow = true;

   /*
    public Color mycolor1;
    public Color red = Color.red;
    public Color blue = Color.blue;
    public Color mycolor2 = new Color();

    public Vector2 way0 = Vector2.zero;
    public Vector3 way1 = Vector3.one;

    public Sprite pic;

    [Header("移動速度"), Range(0.0f,1000.0f)]
    public float speed = 10.5f;

    [Header("跳要高度"), Range(0, 300)]
    public int high = 100;
    */

    #endregion

    #region 方法練習

    private void Start()    {
        test();

        print("來看看第一台車");
        print("品牌 : " + brand);
        print("高度 : " + height);

        haswindow = false;
        weight = 5.5f;

        print("購買輛數" + numder() + "?");
        print("哪泥? 是" + onePfive() + "輛?");

        string yourname = myname();

        print("你是" + yourname + "先生嗎?");


        print("開始駕駛練習模式");

        drive("前", "加速中,請注意",10);
        drive("後", "倒車,請注意安全", 2);
        drive("左", "左轉,請小心", 5);
        drive("右", "右轉,請小心", 5);

        openbrush("開起雨刷",speed : 5);

    }

    public void test()  {
        print("歡迎來到你買不起的車的世界~!");
    }

    public int numder() {
        return 15;
    }

    public float onePfive() {
        return 1.5f;
    }

    public string myname() {
        return "A_meow";
    }

    /// <summary>
    /// 行車練習提示
    /// </summary>
    /// <param name="gomove">行車方向</param>
    /// <param name="sound">提示音效</param>
    /// <param name="speed">行車速度</param>
    public void drive(string gomove, string sound, int speed) {
        print("請向" + gomove + "走");
        print("提示音效 : " + sound);
        print("行車速度" + speed + "km/hr");
    }

    /// <summary>
    /// 開起雨刷
    /// </summary>
    /// <param name="speed">雨刷速度</param>
    /// <param name="sound">提示音效</param>
    public void openbrush(string sound, int count = 2, int speed = 10) {
        print("開起雨刷設定");
        print("雨刷速度 : " + speed);
        print("題是音效 : " + sound);
        print("雨刷數量 : " + count);
    }

    #endregion


}