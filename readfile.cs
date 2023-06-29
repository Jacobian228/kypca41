using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

public class readfile : MonoBehaviour
{
    public GameObject file;
    public GameObject main_menu;
    public UnityEngine.UI.Text inputline;
    public GameObject[] buttons;
    public string name= "SomeFile.txt";
    public void readd(){
        name = inputline.text.ToString();
        if (File.Exists(name))
        {
            file.GetComponent<UnityEngine.UI.Text>().text = System.IO.File.ReadAllText(@name);
        }
    }
    public void exit(){
        buttons = GameObject.FindGameObjectsWithTag("read menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
    public void print()
    {
        name = inputline.text.ToString();
        if (File.Exists(name))
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(name);
            psi.Verb = "PRINT";

            Process.Start(psi);
        }
    }
}
