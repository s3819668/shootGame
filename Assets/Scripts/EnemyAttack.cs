using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float distanceToMe;
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
   void Update()
    {
        Seek();
    }
    //怪物追擊人物
    void Seek()
    {
        //面向人物
        this.transform.LookAt(me.transform);
        //追
        this.transform.Translate(Vector3.forward*0.05f);

    }
}