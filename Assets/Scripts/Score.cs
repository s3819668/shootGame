using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public GameObject ShowText;
    public GameObject victory;
    // Start is called before the first frame update
    private int count=0;
    
    //加分函數
    public  void update_score(int n){
        count+=n;
        //因為count是str不能顯示所以轉字串 並設定ShowText為count
        ShowText.GetComponent<Text>().text =count.ToString();
        //一開始隱藏勝利 如果分數達100則顯示出勝利畫面
        if(count>=100){
            victory.SetActive(true);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //當分數>=60 觸發AddMonster的升級 讓難度變為設定的3
        if (count>=60){
            GameObject.Find("GameObject").GetComponent<AddMonster>().levelup(3); 
        }
        //當分數>=20 觸發AddMonster的升級 讓難度變為設定的2
        else if (count>=20){
            GameObject.Find("GameObject").GetComponent<AddMonster>().levelup(2); 
        }
    }
}
