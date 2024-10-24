using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class time : MonoBehaviour
{
    public float tiempo = 60;
    [SerializeField]
    TextMeshProUGUI tiempoTime;
    

   

  
    void Update()
    {
        tiempo = tiempo - Time.deltaTime;
        Debug.Log (tiempo);
        if (tiempo <= 0 )
        {
            
        }
    }
}
