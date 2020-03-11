using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HostageFollow2 : MonoBehaviour
{
    public Transform ThePlayer;
    static Animator anim;
    //  public GameObject ThePlayer;
    //  public float TargetDistance;
    // public float AlloweDistance = 5;
    //public GameObject TheNPC;
    //public float followSpeed;
    // public RaycastHit Shot;
    private bool Stop = false;
    void Start() {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Stop == false)
        {
            if (Vector3.Distance(ThePlayer.position, this.transform.position) < 20)
            {
                Vector3 direction = ThePlayer.position - this.transform.position;
                direction.y = 0;
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
                //   anim.SetBool(IsWallking, true);
                if (direction.magnitude > 5)
                {
                    this.transform.Translate(0, 0, 0.05f);
                    anim.SetBool("IsWallking", true);
                    SaveScript.Hostage = true;
                }
                else { anim.SetBool("IsWallking", false);
                    SaveScript.Hostage = false;
                }
            }
            else { anim.SetBool("IsWallking", false);
                SaveScript.Hostage = false;
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("HostageTrigger"))
        {
            anim.SetBool("Stop", true);
            Stop = true;
            SaveScript.Hostage = true;
        }
    }

}