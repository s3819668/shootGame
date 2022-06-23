using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//小雞撞到人
public class Hit : MonoBehaviour
{
    public int monsterGiveScore;//小雞價值幾分 不填寫於預製物件時填入可以代表該尺寸小雞價值多少分 
    public int hp =10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //小雞扣血
        hp-=10;
        //當小雞沒血就觸發score的加分函式 並以monsterGiveScore 做傳參代表這小雞價值多少分
        if (hp<=0){
            GameObject.Find("Text").GetComponent<Score>().update_score(monsterGiveScore); 
            //刪除小雞物件
            Destroy(gameObject);
        }
    }
}
