using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Target1;
    [SerializeField] float ChaseSpeed = 10.5f;
    private float NewChaseSpeed = 0.0f;
    [SerializeField] GameObject Patrol;
    [SerializeField] float AttackDistance = 4.0f;
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] float MaxDistance = 20f;
    [SerializeField] bool IHaveAxe = false;
    [SerializeField] bool IHaveBat = false;
    [SerializeField] bool IHaveKnife = false;
    [SerializeField] bool IHaveGun = false;
    public float DistanceToPlayer;
    private bool RunToPlayer = false;
    private Animator anim;
    private NavMeshAgent nav;
    private bool MusicOn = false;
     private bool move = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        Patrol.gameObject.SetActive(true);
        ChaseMusic.gameObject.SetActive(false);
        MusicOn = false;
        NewChaseSpeed = ChaseSpeed;
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
        DistanceToPlayer = Vector3.Distance(Player.position, transform.position);
         
        if (RunToPlayer == true)
        {
            
           if (DistanceToPlayer < MaxDistance)
            {
                if (MusicOn == false)
                {
                    ChaseMusic.gameObject.SetActive(true);
                    MusicOn = true;
                }
            }
          
          if(RunToPlayer=true){
            Patrol.gameObject.SetActive(false);
}

            nav.speed = NewChaseSpeed;
            if(move==true){
            nav.SetDestination(Player.position);
                }
            if (DistanceToPlayer < AttackDistance)
            {
                if (IHaveBat == true)
                {
                    move=false;
                    anim.SetBool("BatAttacks", true);
                    anim.SetBool("Damaging", true);
                    NewChaseSpeed = 6.5f;
                    nav.angularSpeed = 650000000;
                    
                }
                if (IHaveAxe == true)
                {
                   
                    move=false;
                    anim.SetBool("AxeAttacks", true);
                    anim.SetBool("Damaging", true);
                    NewChaseSpeed = 1f;
                    nav.angularSpeed = 650000000;
                }
                if (IHaveKnife == true)
                {
                    move=false;
                    anim.SetBool("KnifeAttacks", true);
                    anim.SetBool("Damaging", true);
                    NewChaseSpeed = 6.5f;
                    nav.angularSpeed = 650000000;
                }
                if (IHaveGun == true)
                {
                    move=false;
                    anim.SetBool("GunAttacks", true);
                    anim.SetBool("Damaging", true);
                  //  SimpleShoot.CanShoot = true;
                    NewChaseSpeed = 6.5f;
                    nav.angularSpeed = 650000000;
                }
            }
            else if (DistanceToPlayer > AttackDistance)
            {
                anim.SetBool("Damaging", false);
                if (IHaveBat == true)
                {
                  
                    anim.SetBool("Alert", true);
                    anim.SetBool("BatAttacks", false);
                    anim.SetBool("Damaging", false);
                   NewChaseSpeed = ChaseSpeed * SaveScript.Difficulty;
                    nav.angularSpeed = 25000;
                     move=true;
                }
                if (IHaveAxe == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("AxeAttacks", false);
                    anim.SetBool("Damaging", false);
                   NewChaseSpeed = ChaseSpeed * SaveScript.Difficulty;
                    nav.angularSpeed = 25000;
                     move=true;
                }
                if (IHaveKnife == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("KnifeAttacks", false);
                    anim.SetBool("Damaging", false);
                    NewChaseSpeed = ChaseSpeed * SaveScript.Difficulty;
                    nav.angularSpeed = 25000;
                     move=true;
                }
                if (IHaveGun == true)
                {
                    anim.SetBool("Alert", true);
                    anim.SetBool("GunAttacks", false);
                    anim.SetBool("Damaging", false);
                   // SimpleShoot.CanShoot = false;
                    NewChaseSpeed = ChaseSpeed * SaveScript.Difficulty;
                    nav.angularSpeed = 25000;
                     move=true;
                }
            }
              
            }
        if (DistanceToPlayer > MaxDistance)
            {
                if (MusicOn == true)
                {
                    ChaseMusic.gameObject.SetActive(false);
                    MusicOn = false;
                    
                   nav.SetDestination(Target1.position);
                    RunToPlayer=false;
                    move=false;
                    Patrol.gameObject.SetActive(true);  
                   Patrol.GetComponent<EnemyMove>().LastTarget=1;
                    Patrol.GetComponent<EnemyMove>().CurrentTarget=1;
                Patrol.GetComponent<EnemyMove>().TargetDescriptor = Patrol.GetComponent<EnemyMove>().EnemyNumber + "TargetCube1";
                anim.SetBool("Alert", true);
                    anim.SetBool("GunAttacks", false);
                  anim.SetBool("Damaging", false);
                 anim.SetBool("KnifeAttacks", false);
                  anim.SetBool("Damaging", false);
                anim.SetBool("AxeAttacks", false);
                  anim.SetBool("Damaging", false);
                anim.SetBool("BatAttacks", false);
                    anim.SetBool("Damaging", false);
                    anim.SetBool("Alert", false);
                   nav.speed =1.5f;
                
                   
                }}
             
        }
    }
