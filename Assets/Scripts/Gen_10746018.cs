using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

//法杖特有技能 隕石術
public class Gen_10746018: MonoBehaviour
{
    public Transform player;
    public GameObject cubePrefab;
    private double cd=0;
    private double skill_keeping=0;
    void Start()
    {
    }
    void Update()
    {
        //冷卻時間計時器
        IEnumerator cd_count()
        {
            while (cd>0)
            {
                if(cd>=0.1){
                    cd-=0.1;
                }
                else{
                    cd=0;
                    break;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
        //持續時間計時器
        IEnumerator sk_count()
        {
            while (skill_keeping>0)
            {
                if(skill_keeping>=0.1){
                    skill_keeping-=0.1;
                }
                else{
                    skill_keeping=0;
                }
                yield return new WaitForSeconds(0.1f);
            }
        }
        //技能控制器
        void skill_exec(){
            StartCoroutine(sk_count());
            StartCoroutine(cd_count());
            StartCoroutine(gen());
        }
        //技能觸發
        if (Input.GetKeyDown (KeyCode.F1) && cd==0)  
        {  
            skill_keeping=5;
            cd=10;
            skill_exec();
        }
        //技能施放控制器
        IEnumerator gen(){
            while (skill_keeping>0)
            {
                //生成隕石
                GameObject ball = Instantiate(cubePrefab) as GameObject;
                ball.transform.position = new Vector3(Random.Range(player.position.x-50,player.position.x+50), Random.Range(20, 30), Random.Range(player.position.z+10, player.position.z+30));
                yield return new WaitForSeconds(0.1f);
            }
        }

    }
}
