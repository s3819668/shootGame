using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    public GameObject magicPrefab;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(attack_cd());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator attack_cd()
        {
            while (true)
            {
               
                if (Input.GetMouseButton(0))
                {
                    GameObject magic = Instantiate(magicPrefab) as GameObject;
                    magic.transform.position = transform.position+Vector3.right;
                }
                yield return new WaitForSeconds(1.1f);
            }
        }
}
