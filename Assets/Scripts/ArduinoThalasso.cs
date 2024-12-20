using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoThalasso : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 115200);
    //SerialPort sp = new SerialPort("COM5", 115200);
    public GameObject player, megalodon;

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
        megalodon.SetActive(false);
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
                if (beatAvg > 100)
                {
                    megalodon.SetActive(true);
                }
            }
            print(linha);
        }
        catch (System.Exception)
        {
        }
    }
}
