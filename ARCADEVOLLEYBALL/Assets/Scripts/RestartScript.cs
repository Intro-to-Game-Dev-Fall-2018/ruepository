using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
