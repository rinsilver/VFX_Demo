using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanDien : MonoBehaviour
{
    [SerializeField]
    private GameObject electricityPower;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            electricityPower.SetActive(true);
        }
        
    }
}
