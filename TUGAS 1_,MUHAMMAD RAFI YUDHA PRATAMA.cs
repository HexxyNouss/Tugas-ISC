//Muhammad Rafi Yudha Pratama
//C2C022061

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showmurid : MonoBehaviour
{

public string[] murid;

    public float waktu;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        waktu += Time.deltaTime;

        if (waktu > 1){
            waktu = 0;
            Debug.Log(murid[index]);
            // Variasi 1
            // index++;
            // if (index >= murid.Length) index = 0;

            // Variasi 2
            index = (index+1) % murid.Length;
        }

    }
}
