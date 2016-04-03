using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/* Kiírja hányszor rajzolódik ki egy kép másodpercenként (képkocka/másodperc)*/
/* Unity oldaláról töltve, szabadon felhasználható, kisebb módosításokat végeztem rajta*/

public class FPS : MonoBehaviour
{
    public float updateInterval = 0.5F;

    private float accum = 0; // FPS accumulated over the interval
    private int frames = 0; // Frames drawn over the interval
    private float timeleft; // Left time for current interval

    void Start()
    {
        timeleft = updateInterval;
    }

    void Update()
    {
       
            PrintFPS();
       
    }

    void PrintFPS()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        // Interval ended - update GUI text and start new interval
        if (timeleft <= 0.0)
        {
            float fps = accum / frames;
            GetComponent<Text>().text = (int)fps + " FPS";

            if (fps < 30)
                GetComponent<Text>().material.color = Color.yellow;
            else
                if (fps < 10)
                    GetComponent<Text>().material.color = Color.red;
                else
                    GetComponent<Text>().material.color = Color.green;

            

            timeleft = updateInterval;
            accum = 0.0F;
            frames = 0;
        }

    }

   
}
