using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{
    private float currentLapMill;
    private float currentLapSecond;
    private float currentLapMinute;
    public float fastestLapMill;
    public float fastestLapSecond;
    public float fastestLapMinute;
    private float lastRoundTimeMill;
    private float lastRoundTimeSecond;
    private float lastRoundTimeMinute;
    public Text lapTime;
    public CarLaps carlap;
    public GameObject button;
    public GameObject car;
    public Text text5;
    public Text time;

    // Start is called before the first frame update
    void Start()
    {
        carlap = GetComponent<CarLaps>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount();

    }
    void timeCount()
    {
        currentLapMill += Time.deltaTime * 10;

        if (currentLapMill >= 10)
        {
            currentLapMill = 0;
            currentLapSecond += 1;
        }

        if (currentLapSecond >= 60)
        {
            currentLapSecond = 0;
            currentLapMinute += 1;
        }

        lapTime.GetComponent<Text>().text = "Time: " + currentLapMinute.ToString("F0") + "." + currentLapSecond.ToString("F0") + "." + currentLapMill.ToString("F0");

        if (carlap.lap == 2 && carlap.checkpoint == 0)
        {
            fastestLapMill = currentLapMill;
            fastestLapSecond = currentLapSecond;
            fastestLapMinute = currentLapMinute;

            lastRoundTimeMill = currentLapMill;
            lastRoundTimeSecond = currentLapSecond;
            lastRoundTimeMinute = currentLapMinute;

            Debug.Log("Fastest Time" + fastestLapMinute.ToString("F0") + "." + fastestLapSecond.ToString("F0") + "." + fastestLapMill.ToString("F0"));
        }

        if (carlap.lap == 3 && carlap.checkpoint == 0)
        {
            if (fastestLapMinute > lastRoundTimeMinute)
            {
                fastestLapMill = currentLapMill - fastestLapMill;
                fastestLapSecond = currentLapSecond - fastestLapSecond;
                fastestLapMinute = currentLapMinute - fastestLapMinute;
            }
            else if (fastestLapMinute < currentLapMinute)
            {
                if (fastestLapSecond > lastRoundTimeSecond)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else if (fastestLapSecond < lastRoundTimeSecond)
            {
                if (fastestLapMill > lastRoundTimeMill)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else
            {
                Debug.Log("Lap not fast enough");
            }
            lastRoundTimeMill = currentLapMill;
            lastRoundTimeSecond = currentLapSecond;
            lastRoundTimeMinute = currentLapMinute;
            Debug.Log("Fastest Time" + fastestLapMinute.ToString("F0") + "." + fastestLapSecond.ToString("F0") + "." + fastestLapMill.ToString("F0"));
        }

        if (carlap.lap == 4 && carlap.checkpoint == 0)
        {
            lastRoundTimeMill = currentLapMill - lastRoundTimeMill;
            lastRoundTimeSecond = currentLapSecond - lastRoundTimeSecond;
            lastRoundTimeMinute = currentLapMinute - lastRoundTimeMinute;

            if (fastestLapMinute > lastRoundTimeMinute)
            {
                fastestLapMill = currentLapMill - fastestLapMill;
                fastestLapSecond = currentLapSecond - fastestLapSecond;
                fastestLapMinute = currentLapMinute - fastestLapMinute;
            }
            else if (fastestLapMill < lastRoundTimeMill)
            {
                if (fastestLapSecond > lastRoundTimeSecond)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else if (fastestLapSecond < lastRoundTimeSecond)
            {
                if (fastestLapMill > lastRoundTimeMill)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else
            {
                Debug.Log("Lap not fast enough");
            }
            lastRoundTimeMill = currentLapMill;
            lastRoundTimeSecond = currentLapSecond;
            lastRoundTimeMinute = currentLapMinute;
            Debug.Log("Fastest Time" + fastestLapMinute.ToString("F0") + "." + fastestLapSecond.ToString("F0") + "." + fastestLapMill.ToString("F0"));
        }

        if (carlap.lap == 5 && carlap.checkpoint == 0)
        {
            lastRoundTimeMill = currentLapMill - lastRoundTimeMill;
            lastRoundTimeSecond = currentLapSecond - lastRoundTimeSecond;
            lastRoundTimeMinute = currentLapMinute - lastRoundTimeMinute;

            if (fastestLapMinute > lastRoundTimeMinute)
            {
                fastestLapMill = currentLapMill - fastestLapMill;
                fastestLapSecond = currentLapSecond - fastestLapSecond;
                fastestLapMinute = currentLapMinute - fastestLapMinute;
            }
            else if (fastestLapMill < lastRoundTimeMill)
            {
                if (fastestLapSecond > lastRoundTimeSecond)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else if (fastestLapSecond < lastRoundTimeSecond)
            {
                if (fastestLapMill > lastRoundTimeMill)
                {
                    fastestLapMill = currentLapMill - fastestLapMill;
                    fastestLapSecond = currentLapSecond - fastestLapSecond;
                    fastestLapMinute = currentLapMinute - fastestLapMinute;
                }
            }
            else
            {
                Debug.Log("Lap not fast enough");
            }
            lastRoundTimeMill = currentLapMill;
            lastRoundTimeSecond = currentLapSecond;
            lastRoundTimeMinute = currentLapMinute;
            Debug.Log("Fastest Time" + fastestLapMinute.ToString("F0") + "." + fastestLapSecond.ToString("F0") + "." + fastestLapMill.ToString("F0"));
            car.SetActive(false);
            button.SetActive(true);
            text5.enabled = true;
            time.GetComponent<Text>().text = "Your fastest Time was: " + fastestLapMinute.ToString("F0") + "." + fastestLapSecond.ToString("F0") + "." + fastestLapMill.ToString("F0");
        }
    }
}
