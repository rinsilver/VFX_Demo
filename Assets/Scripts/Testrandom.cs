using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testrandom : MonoBehaviour
{
    public List<GameObject> ojb = new List<GameObject>();
    public List<int> preriousNumb = new List<int>();
    void Start()
    {
        
        for (int i = 0; i < ojb.Count/2; i++)
        {
            int c = Random.Range(0, ojb.Count);
            
            preriousNumb.Add(c);
            if (preriousNumb.Contains(c))
            {
                c = Random.Range(0, ojb.Count);
            }
            Debug.Log(c);

        }

        
    }

    void StartRandom(int index)
    {
        ojb[index].GetComponent<Collider>().enabled = false;
    }

}
