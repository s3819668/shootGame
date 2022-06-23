using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_10746018: MonoBehaviour
{
    private Animator animator;//移動動畫
    public float MoveSpeed=10;//移動速度
    private float horizontal;
    private float vertical;
    private float gravity=9.8f;//假重力 因為Is trigger會使物理效果消失 所以仿造一個
    public int JumpSpeed=10;//跳高
    public CharacterController PlayerController;
    Vector3 Player_Move;

    void Start()
    {
        // 取得元件
        // characterController = GetComponent<CharacterController>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //當人物在地板上時
        if(PlayerController.isGrounded){
            horizontal=Input.GetAxis("Horizontal");
            vertical=Input.GetAxis("Vertical"); 
            Player_Move=(transform.forward*vertical+transform.right*horizontal)*MoveSpeed;
            //當 水平或垂直 有在動 表示有在動故播放動畫
            if(horizontal!=0 || vertical!=0){
                animator.SetBool("running",true);
            }
            else{
                animator.SetBool("running",false);
            }

            if (Input.GetAxis("Jump")==1){
                Player_Move.y=Player_Move.y+JumpSpeed;
            }
        }
        //持續給予假重力
        Player_Move.y=Player_Move.y-gravity*Time.deltaTime;
        //執行前面所有位子描述(移動)
        PlayerController.Move(Player_Move*Time.deltaTime);

    }
}
