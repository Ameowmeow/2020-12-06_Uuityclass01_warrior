using UnityEngine;

/// <summary>
/// API
/// </summary>
public class unityAPI : MonoBehaviour
{
    public void Start()
    {

        #region 靜態屬性
        print("隨機數字 : " + Random.value);

        print("Pi : " + Mathf.PI);
        #endregion

        #region 靜態方法

        int number = Random.Range(-10, 10);

        print("隨機數字 : " + number);

        print("取絕對值 : " + Mathf.Abs(number));

        //練習

        print("we have " + Camera.allCameras.Length + " camera.");




        #endregion

    }
}
