using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Drive : MonoBehaviour
{
    public Text TextGameObject;
    private string text;

  
    private void Start()
    {
        text = GetComponent<Text>().text;
        GetComponent<Text>().text = "";
        StartCoroutine(TextCoroutine());
    }

    IEnumerator TextCoroutine()
    {
        foreach(char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(0.05f);
        }
    }
        



}
