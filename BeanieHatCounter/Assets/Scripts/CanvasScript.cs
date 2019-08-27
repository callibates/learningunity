using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject fooText;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) { 
        Debug.Log("Pressed primary button.");
        counter++;
        Text text = fooText.GetComponent<Text>();
        text.text = counter + "";
        }
    }
    void updateText()
    {
        Text text = GetComponentInChildren<Text>();

        text.text = "blah";
    }

}
