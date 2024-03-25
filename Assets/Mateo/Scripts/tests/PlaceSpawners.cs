using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSpawners : MonoBehaviour
{
    GameObject[] spawners;
    // Start is called before the first frame update
    void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("spawner");
        place();
    }


    private void place(){
        int count=0;
        for (int i = -40; i <=40;i+=10){
            for (int j = -40; j<=40; j+=10){
                spawners[count].transform.position = new Vector3(i, 1, j);
                count++;
            }
        }
    }

}
