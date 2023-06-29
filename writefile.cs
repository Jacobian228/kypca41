using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class writefile : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject main_menu;
    public string path;
    public UnityEngine.UI.Text inputline;
    public void newfile()
    {
        path = inputline.text.ToString();
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path+".txt"))
            {
                sw.WriteLine("");
            }
        }
        buttons = GameObject.FindGameObjectsWithTag("generation menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
    public void exit()
    {
        buttons = GameObject.FindGameObjectsWithTag("generation menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
}
