using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimator : MonoBehaviour
{
    
    private Animator animator;
    CharacterController characterController;
    //動畫冷卻時間
    private double attack_cd =0;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        //取得動畫
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //如果按下左鍵且攻擊冷卻完畢 則啟動攻擊動畫
        if (Input.GetMouseButton(0) && attack_cd==0 )
            {
                attack_cd=0.2f;
                StartCoroutine(attack_cd_count());
                animator.SetBool("attacking1",Input.GetMouseButton(0));

            }
        else{
            animator.SetBool("attacking1",false);
        }
        animator.SetBool("attacking2",Input.GetMouseButton(1));

    }
    //攻擊冷卻延遲延遲副程式 原因:ieee754 浮點數溢位造成 0.1-0.1不等於0的狀況
    IEnumerator attack_cd_count()
        {
            while (attack_cd>0)
            {
                if(attack_cd>=0.1){
                    attack_cd-=0.1;
                }
                else{
                    attack_cd=0;
                    break;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
}









































































