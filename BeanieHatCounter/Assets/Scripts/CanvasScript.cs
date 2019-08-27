using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject fooText;
    private int counter;
    public EnterButtonScript ebScript;

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
            int rowsNeeded = ebScript.GetRowsNeeded();
            Text text = fooText.GetComponent<Text>();
            if (counter < rowsNeeded)
            {
                counter++;

                text.text = counter + "";
            }
            else
            {
                text.text = "!!!!";
            }
        }
    }

}
