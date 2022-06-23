using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //子彈生成兩秒後毀滅
        Destroy(gameObject,2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void shoot(Vector3 dir)
    {
        //賦予子彈空氣動力學
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
