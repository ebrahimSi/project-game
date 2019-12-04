using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;
    [SerializeField] Transform Target3;

    [SerializeField] int CurrentTarget = 1 ;

    private Transform TargetPosition;

    [SerializeField] int waitTime = 0;

    private Animator anim;

    private bool Contact = false;



    // Start is called before the first frame update
    void Start()
    {
        
        TargetPosition = Target1;
        MoveToTarget();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.CompareTag("EnemyTarget"))
        {
            if (Contact == false)
            {
                Contact = true;
                CurrentTarget++;

                if(CurrentTarget > 3)
                {
                    CurrentTarget = 1;
                }

                StartCoroutine(Waiting());

                
            }
        }
    }


    void MoveToTarget()
    {
        if(CurrentTarget == 1)
        {

            TargetPosition = Target1;
        }

        if (CurrentTarget == 2)
        {

            TargetPosition = Target2;
        }

        if (CurrentTarget == 3)
        {

            TargetPosition = Target3;
        }

        GetComponent<NavMeshAgent>().destination = TargetPosition.position;
       // Contact = false;

    }

    IEnumerator Waiting()
    {
        anim.SetInteger("State", 1);
        yield return new WaitForSeconds(waitTime);
        anim.SetInteger("State", 0);
        Contact = false;
        MoveToTarget();
    }
}
