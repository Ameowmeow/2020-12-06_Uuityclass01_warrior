using UnityEngine;

public class API : MonoBehaviour
{
    public SpriteRenderer iteam01;

    public GameObject iteamobject01;

    public Transform iteamtransform01;

    private void Start()
    {
        print("物件顏色:" + iteam01.color);

        print("圖層:" + iteamobject01.layer);

        iteam01.flipX = true;

        print("翻轉左右" + iteam01.flipX);

        iteamobject01.layer = 5;

        print("改變圖層" + iteamobject01.layer);


    }

    public void Update()
    {
        iteamtransform01.Translate(0.5f, 0, 0, Space.World);
    }
}
