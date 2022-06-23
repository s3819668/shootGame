using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGun : MonoBehaviour
{
    public GameObject Follow;
    GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //槍口位置=攝影機位置 故旋轉時攝影機旋轉 槍口方塊旋轉
        bullet=Follow;
        transform.rotation=bullet.transform.rotation;
    }
}
