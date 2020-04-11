using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HostageFollow : MonoBehaviour
{
    [SerializeField] Transform Player;
    private Animator anim;
    [SerializeField] float FollowDistance = 4.0f;
    private bool RunToPlayer = false;
    public float DistanceToPlayer;
    private NavMeshAgent nav;
    private bool move = true;
    private bool HostageTrig = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      //  if (RunToPlayer == true) {
         //   DistanceToPlayer = Vector3.Distance(Player.position, transform.position);
          //  if (move == true)
          //  {
            //    nav.SetDestination(Player.position);
            //}
          //  if (DistanceToPlayer < FollowDistance)
          //  {
            //    move = false;
              //  nav.speed = 0f;
             //   anim.SetBool("IsWallking", false);
          //  }
           // if (DistanceToPlayer > FollowDistance)
           // {
//move = true;
             //   nav.speed = 3.5f;
              //  anim.SetBool("IsWallking", true);
              //  nav.SetDestination(Player.position);
           // }
       // }

    }

    private void OnTriggerEnter(Collider other)
    {
       // if (HostageTrig == false)
       // {
          //  if (other.gameObject.CompareTag("Player"))
          //  {
           //     RunToPlayer = true;
              //  anim.SetBool("IsWallking", true);
          //  }

      //  }
        if (other.gameObject.CompareTag("HostageTrigger"))
        {
           // RunToPlayer = false;
            HostageTrig = true;
            anim.SetBool("Stop", true);
            nav.speed = 0f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
       
           // if (other.gameObject.CompareTag("Player"))
          //  {
              //  RunToPlayer = false;
           //     anim.SetBool("IsWallking", false);
         //  } 
          }
}
