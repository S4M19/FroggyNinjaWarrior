using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reanimar : MonoBehaviour
{
    void Update()
    {
        if (DamagePlayer.damageSignal)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
}
