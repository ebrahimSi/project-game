using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ButcherKill : MonoBehaviour
{
    [SerializeField] GameObject CameraMain;
    private NavMeshAgent nav;
    [SerializeField] GameObject Butcher;
    [SerializeField] GameObject Player;
    
    [SerializeField] GameObject CameraButcher;
    // Start is called before the first frame update
    void Start()
    {
        nav = Butcher.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Other) {
        if (Other.gameObject.CompareTag("Butcher"))
        {
            nav.enabled = false;
            Player.GetComponent<CharController_Motor>().enabled=false;
            CameraMain.gameObject.SetActive(false);
            CameraButcher.gameObject.SetActive(true);
            SaveScript.PlayerHealth = 1;
            SaveScript.DisplayHealth = true;
        }
    }
}
