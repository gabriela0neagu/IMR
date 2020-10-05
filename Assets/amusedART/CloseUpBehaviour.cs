using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUpBehaviour : MonoBehaviour
{
   public Animator animator;
   public GameObject AR;
   public GameObject rabbit;

    // Start is called before the first frame update
    void Start()
    {
      animator.SetBool("closeUp", false);

   }

   // Update is called once per frame
   void Update()
    {
      float dist = Vector3.Distance(AR.transform.position, rabbit.transform.position);
      if(dist <= 10)
      {
         animator.SetBool("closeUp", true);
      }
      else
      {
         animator.SetBool("closeUp", false);
      }
   }
}
