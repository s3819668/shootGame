using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    public int pass=1;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    // Start is called before the first frame update
    void Start()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
        weapon3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))    // 按下數字鍵 1 大劍
        {
            //改善執行效率以及避免傳參次數隨判定次數增加 寫入防彈跳 上一次如果選這把武器 按住不會再次選這把
            if(pass!=1){
                weapon1.GetComponent<GenBullet>().make_cd_zero();
                pass=1;
                weapon1.SetActive(true);
                weapon2.SetActive(false);
                weapon3.SetActive(false);
            }
            
        }
        else if (Input.GetKey(KeyCode.Alpha2))   // 按下數字鍵 2 法杖
        {
            //改善執行效率以及避免傳參次數隨判定次數增加 寫入防彈跳 上一次如果選這把武器 按住不會再次選這把
            if(pass!=2){
                weapon2.GetComponent<GenBullet>().make_cd_zero();
                pass=2;
                weapon1.SetActive(false);
                weapon2.SetActive(true);
                weapon3.SetActive(false);
            }
            
        }
        else if (Input.GetKey(KeyCode.Alpha3))   // 按下數字鍵 3 弓
        {
            //改善執行效率以及避免傳參次數隨判定次數增加 寫入防彈跳 上一次如果選這把武器 按住不會再次選這把
            if(pass!=3){
                weapon3.GetComponent<GenBullet>().make_cd_zero();
                pass=3;
                weapon1.SetActive(false);
                weapon2.SetActive(false);
                weapon3.SetActive(true);
            }
            
        }
    }
}
