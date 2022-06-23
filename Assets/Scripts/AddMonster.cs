using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMonster : MonoBehaviour
{
    public GameObject small;
    public GameObject mid;
    public GameObject big;
    public int level = 1;
    public double monsterInterval=0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemy(level));
    }

    void Update()
    {
        //如果生成怪物冷卻==0 則呼叫生成怪物副程式
        if(monsterInterval==0){
            monsterInterval=2;
            StartCoroutine(CreateEnemy(level));
        }
        
    }

    //生成怪物副程式
    IEnumerator CreateEnemy(int level){
            //讓副程式每0.1秒檢查 並遞減 使用if else 設定冷卻為0  原因:ieee754 浮點數溢位造成 0.1-0.1不等於0的狀況 而無法符合update中==0
            while(monsterInterval>0){
                //如果冷卻中則每0.1秒過後減少當前冷卻0.1秒
                if (monsterInterval>=0.1){
                    monsterInterval-=0.1;
                }
                else{
                    //冷卻歸0時
                    //小雞位子
                    Vector3 suiji = this.transform.position;
                    suiji.x = this.transform.position.x + Random.Range(-20.0f,20.0f);
                    suiji.z = this.transform.position.z + Random.Range(-20.0f,20.0f);
                    suiji.y = 1;

                    //指定當前生成小雞尺寸
                    GameObject monster;
                    if (level==1){
                        monster=small;
                    }
                    else if(level==2){
                        monster=mid;
                    }
                    else{
                        monster=big;
                    }
                    //生成小雞
                    Instantiate(monster,suiji,Quaternion.identity);
                    monsterInterval=0;
                    break;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }


    //給score去call 當分數到了就把當前遊戲難度提升
    public void levelup(int lv){
        level=lv;
    }

}
