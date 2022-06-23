using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//法杖技能隕石的控制
public class meteorite: MonoBehaviour
{
    public GameObject meteorites;
    private double kill_itself =10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(kill_itself_count());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //隕石存在最多10秒
    IEnumerator kill_itself_count()
        {
            while (kill_itself>0)
            {
                if(kill_itself>=0.1){
                    kill_itself-=0.1;
                }
                else{
                    Destroy(gameObject);
                }
                yield return new WaitForSeconds(0.1f);
            }
        }


    //當碰撞則刪除物件
    private void OnTriggerEnter(Collider other)
    {
        //當隕石落地 製造一個爆炸效果的物件讓他看起來爆炸
        GameObject clone=(GameObject)Instantiate(meteorites,transform.position,transform.rotation);
        //刪去隕石
        Destroy(gameObject);
        //刪去爆炸的效果物件
        Destroy (clone, 0.5f);

    }
}
