using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound : MonoBehaviour
{
    [SerializeField] AudioSource sound1;
    //sund1 is normal
    [SerializeField] AudioSource sound2;
    // sound2 is grass
    [SerializeField] AudioSource sound3;
    //sound 3 is wood
    CharacterController cc;

    CharController_Motor ccm;
    public int Type = 1;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        ccm = GetComponent<CharController_Motor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ccm.speed == ccm.RunSpeed)
        {
            sound1.pitch = 2;
            sound2.pitch = 2;
            sound3.pitch = 2;
        }
        else { sound1.pitch = 1;
            sound2.pitch = 1;
            sound3.pitch = 1;
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && sound1.isPlaying == false && Type==1) {
            sound1.Play();
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && sound2.isPlaying == false && Type == 2)
        {
            sound2.Play();
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 2f && sound3.isPlaying == false && Type == 3)
        {
            sound3.Play();
        }
    }
}
