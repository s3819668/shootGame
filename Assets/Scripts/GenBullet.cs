using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//生成子彈
public class GenBullet : MonoBehaviour
{
    
    private Animator animator;
    CharacterController characterController;
    public GameObject BulletPrefab;
    public Transform BulletSpawn;
    public float BulletSpeed=100;
    private double attack_cd_counter =0;
    public double attack_cd;//子彈冷卻不填入 因此預製物件可以填入每種子彈的冷卻時間 藉以控制每種武器強度
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        attack_cd_counter =0;
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (Input.GetMouseButton(0) && attack_cd_counter==0 )
            {
                
                attack_cd_counter=attack_cd;
                StartCoroutine(attack_cd_counter_count());
            }
        

    }
    //子彈冷卻
    IEnumerator attack_cd_counter_count()
        {
            GameObject bullet =Instantiate(BulletPrefab,BulletSpawn.position,BulletSpawn.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().velocity=bullet.transform.forward*BulletSpeed;
            while (attack_cd_counter>0)
            {
                if(attack_cd_counter>=0.1){
                    attack_cd_counter-=0.1;
                }
                else{
                    
                    attack_cd_counter=0;
                    break;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
    //換武器時會setactive(false)會造成下面IEnumerator沒跑完 所以換武器call這個副程式把武器冷卻歸0
    public void make_cd_zero(){
       attack_cd_counter=0;
    }
}

