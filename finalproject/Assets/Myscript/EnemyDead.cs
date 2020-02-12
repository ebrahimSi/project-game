using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    [SerializeField] GameObject ChaseMusic;
    [SerializeField] int EnemyNumber;
    // Start is called before the first frame update
    void Start()
    {
        ChaseMusic.gameObject.SetActive(false);
        /*  if (EnemyNumber == 1)
          {
              SaveScript.Enemy1 = 0;
          }
          if (EnemyNumber == 2)
          {
              SaveScript.Enemy2 = 0;
          }
          if (EnemyNumber == 3)
          {
              SaveScript.Enemy3 = 0;
          }
          if (EnemyNumber == 4)
          {
              SaveScript.Enemy4 = 0;
          }
          if (EnemyNumber == 5)
          {
              SaveScript.Enemy5 = 0;
          }
          if (EnemyNumber == 6)
          {
              SaveScript.Enemy6 = 0;
          }
      }
      */
    }
}