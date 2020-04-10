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
            sound1.pitch = 1.2f;
            sound2.pitch = 1.2f;
            sound3.pitch = 1.2f;
        }
        else { sound1.pitch = 0.7f;
            sound2.pitch = 0.7f;
            sound3.pitch = 0.7f;
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 3f && sound1.isPlaying == false && Type == 1 && (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D))) {
            sound1.Play();
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 3f && sound2.isPlaying == false && Type == 2 && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            sound2.Play();
        }
        if (cc.isGrounded == true && cc.velocity.magnitude > 3f && sound3.isPlaying == false && Type == 3 && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            sound3.Play();
        }
    }
}
