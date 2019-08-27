using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterButtonScript : MonoBehaviour
{
	public Text enterField;
	static int rowsNeeded;
    // Start is called before the first frame update
    void Start()
    {
		rowsNeeded = 0;
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick()
    {
		GetNum();
        SceneManager.LoadScene("SampleScene");
    }

    void GetNum()
	{
		string stringVersion = enterField.text.ToString();
		rowsNeeded = int.Parse(stringVersion);
		Debug.Log("num is" + rowsNeeded);
	}
}
