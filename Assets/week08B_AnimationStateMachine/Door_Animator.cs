using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Animator : MonoBehaviour
{
    public GameObject Pivot;

   /* private void OnColisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        print("enter " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        print("exit "+ other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}
