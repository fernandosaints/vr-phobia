using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoNicto : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 115200);
    //SerialPort sp = new SerialPort("COM5", 115200);
    public GameObject dogHowl;
    bool played;

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
        played = false;
    }

    void Update()
    {
        try
        {
            var beatAvg = 0;
            var linha = sp.ReadLine();
            if (linha != "No finger?")
            {
                beatAvg = int.Parse(linha);
                if (beatAvg > 100 && !played)
                {
                    dogHowl.GetComponent<AudioSource>().Play();
                    played = true;
                }
            }
            print(linha);
        }
        catch (System.Exception)
        {
        }
    }
}
