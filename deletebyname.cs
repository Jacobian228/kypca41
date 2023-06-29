using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class deletebyname : MonoBehaviour
{
    public string name;
    public string path;
    public string dep;
    public GameObject main_menu;
    public UnityEngine.UI.Text inputline1;
    public UnityEngine.UI.Text inputline2;
    public UnityEngine.UI.Text inputline3;
    public GameObject[] buttons;

    public void exit()
    {
        buttons = GameObject.FindGameObjectsWithTag("read menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
    public void delete()
    {
        name = inputline2.text.ToString();
        path = inputline1.text.ToString();
        if (File.Exists(path))
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(path))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dababy = line.Split(' ');
                    if (dababy[1] != name)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            File.Delete(path);
            File.Move(tempFile, path);
        }
        exit();
    }
    public void move()
    {
        dep = inputline3.text.ToString();
        name = inputline2.text.ToString();
        path = inputline1.text.ToString();
        if (File.Exists(path))
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(path))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dababy = line.Split(' ');
                    if (dababy[1] != name)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        string newline = dep+" ";
                        for (int i=1;i<dababy.Length;i++) {
                            newline = newline + dababy[i] + " ";
                        }
                        sw.WriteLine(newline);
                    }
                }
            }
            File.Delete(path);
            File.Move(tempFile, path);
        }
        exit();
    }
}
