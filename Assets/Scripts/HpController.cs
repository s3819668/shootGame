using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
//血量控制器 
public class HpController : MonoBehaviour
{
    public const int maxHealth = 100;//最大血量
    public int currentHealth = maxHealth;
    public GameObject self;//拖入血量要被控制的物件
    public RectTransform remainHP;
    public GameObject defeat;//顯示失敗畫面
    
    void OnTriggerEnter(Collider other)
    {
        //指定玩家以及城堡
        string[] excludeArray = { "player",  "player_castle"};
        if(!excludeArray.Contains(other.gameObject.name) && remainHP.rect.width > 0)
        {
            currentHealth = currentHealth - 10;
            //重新設定血條寬度讓他看起來減少
            remainHP.sizeDelta = new Vector2(currentHealth, remainHP.sizeDelta.y);
        }
        //當沒血就失敗 一開始先隱藏 沒血才觸發
         if(remainHP.rect.width <= 0){
            defeat.SetActive(true);
  }
    }
}
