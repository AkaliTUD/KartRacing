using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingRace : MonoBehaviour
{
    public Text text2;
    private int time = 3;
    public GameObject car;
    public CarLaps lapcar;
    public GameObject button;
    public Text text5;
    // Start is called before the first frame update
    void Start()
    {
        time = 3;
        text2.enabled = true;
        car.SetActive(false);
        button.SetActive(false);
        text5.enabled = false;
        StartCoroutine(RaceStart());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator RaceStart()
    {
        while (time > 0)
        {
            text2.GetComponent<Text>().text = time.ToString();
            yield return new WaitForSeconds(1.0f);
            time--;
        }
        text2.enabled = false;
        car.SetActive(true);
    }
}
