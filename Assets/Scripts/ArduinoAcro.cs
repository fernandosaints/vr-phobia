using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoAcro : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 115200);
    //SerialPort sp = new SerialPort("COM5", 115200);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
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
                if (beatAvg > 70)
                {
                    GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.red;
                }
            }
            print(linha);
        }
        catch (System.Exception)
        {
        }
    }
}