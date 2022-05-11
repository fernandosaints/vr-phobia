using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoSAFE : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 115200);
    //SerialPort sp = new SerialPort("COM5", 115200);
    public GameObject textGameObject;

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        try
        {
            var linha = sp.ReadLine();
            //var beatAvg = 0;
            //if (linha != "No finger?")
            //{
            //    beatAvg = int.Parse(linha);
            //}
            textGameObject.GetComponent<UnityEngine.UI.Text>().text = linha;
            print(linha);
        }
        catch (System.Exception)
        {
        }
    }
}