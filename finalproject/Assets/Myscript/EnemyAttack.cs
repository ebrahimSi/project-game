using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAttack : MonoBehaviour
{

    [SerializeField] Transform Player;
    [SerializeField] float ChaseSpeed = 10.5f;
    [SerializeField] GameObject Patrol;
    [SerializeField] float AttackDistance = 2.6f;
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] float MaxDistance = 20f;


    public float DistanceToPlayer;

    private bool RunToPlayer = false;
    private Animator anim;
    private NavMeshAgent Nav;
    private bool MusicOn = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Nav = GetComponent<NavMeshAgent>();
        Patrol.gameObject.SetActive(false);
        ChaseMusic.gameObject.SetActive(false);
        MusicOn = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerPlayer"))
        {
            RunToPlayer = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (RunToPlayer == true)
        {
            DistanceToPlayer = Vector3.Distance(Player.position, transform.position);

            if (DistanceToPlayer < MaxDistance)
            {
                if (MusicOn == false)
                {
                    ChaseMusic.gameObject.SetActive(true);
                    MusicOn = true;
                }
            }
            else if (DistanceToPlayer > MaxDistance)
            {
                if (MusicOn == true)
                {
                    ChaseMusic.gameObject.SetActive(false);
                    MusicOn = false;
                }
            }


            // Patrol.gameObject.SetActive(false);
            Nav.speed = ChaseSpeed;
            Nav.SetDestination(Player.position);


            if (DistanceToPlayer < AttackDistance)
            {
                anim.SetBool("Alert", false);
            }
            else if (DistanceToPlayer > AttackDistance)
            {
                anim.SetBool("Alert", true);
            }
        }
    }
}
