using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearman : MonoBehaviour
{
   public Transform target;

    void Start()
    {
        
    }

    
    void Update()
    {
        float dist = Vector3.Distance(Transform.position,target.position);
        Vector3 targetPos;

        if(dist < 8)
        {
            targetPos = new Vector3 (transform.posittion.x)
        }
    }
}
