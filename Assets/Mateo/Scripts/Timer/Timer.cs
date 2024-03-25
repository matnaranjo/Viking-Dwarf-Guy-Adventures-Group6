using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    IEnumerator CrystalTimer(GameObject spawnerPoint){
        yield return new WaitForSeconds(30);
    }
}
