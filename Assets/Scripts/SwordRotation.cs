using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//劍的攻擊動畫 因為想不到用什麼 只好把他當飛刀了 
public class SwordRotation : MonoBehaviour
{
    float i=0;
    
    // Start is called before the first frame update
    void Start()
    {
        //讓他一開始有個角度才不會看起來很怪有丟刀的感覺
        transform.Rotate(-135f, 0.0f,0.0f, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        //不斷增加他的x角度讓他看起來在轉
        i++;
        transform.Rotate(i, 0.0f, 0.0f, Space.Self);
    }
}
