using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class levelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;


    // Update is called once per frame
    void Update()
    {
        if(addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }    
    }
    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(0.35f);
        addingDis = false;    
    }

}
