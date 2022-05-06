using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 115200);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        try
        {
            print(sp.ReadLine());
        }
        catch (System.Exception)
        {
        }
    }
}