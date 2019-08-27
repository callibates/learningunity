using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterButtonScript : MonoBehaviour
{
	public Text enterField;
	public static int rowsNeeded = 0;
    // Start is called before the first frame update
    public void Start()
    {
		rowsNeeded = 0;
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void onClick()
    {
		GetNum();
        SceneManager.LoadScene("SampleScene");
    }

    public void GetNum()
	{
		string stringVersion = enterField.text.ToString();
		rowsNeeded = int.Parse(stringVersion);
	}
    public int GetRowsNeeded()
	{
		return rowsNeeded;
	}
}
