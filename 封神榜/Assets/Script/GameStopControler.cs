using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopControler : MonoBehaviour
{
    // Start is called before the first frame update

    private bool isstop;
    public GameObject option;
    void Start()
    {
        isstop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            option.GetComponent<OptionControler>().Show();
        }
    }
}
