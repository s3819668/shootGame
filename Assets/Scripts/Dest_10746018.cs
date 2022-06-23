using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest_10746018: MonoBehaviour
{   //宣告物件
    public GameObject get_ball_position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //物件的Y小於0則刪除

        get_ball_position.GetComponent<Transform>().position = transform.position;
       if (get_ball_position.GetComponent<Transform>().position.y<0)
        {
            Destroy(get_ball_position);
        }

    }
}
