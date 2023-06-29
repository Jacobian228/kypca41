using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class babylook : MonoBehaviour
{
    public GameObject file;
    public GameObject main_menu;
    public UnityEngine.UI.Text inputline;
    public GameObject[] buttons;
    string bababooey="";
    int number=0;
    int numba=0;
    public string name = "SomeFile.txt";
    public void readd()
    {
        bababooey = "";
        name = inputline.text.ToString();
        if (File.Exists(name))
        {
            using (StreamReader sr = File.OpenText(name))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    int count = 0;
                    string[] dababy=s.Split(' ');
                    for (int i = 4; i < dababy.Length; i++)
                    {
                        bool succeess = int.TryParse(dababy[i],out number);
                        if (succeess)
                        {
                            if (number<18)
                            {
                                for (int j = 4; j < dababy.Length; j++)
                                {
                                    bool suces = int.TryParse(dababy[j], out numba);
                                    if (suces)
                                    {
                                        if (numba < 18)
                                        {
                                            count++;
                                        }
                                    }
                                }
                                bababooey = bababooey + dababy[0] + " " + dababy[1] + " " + count + "\n";
                                count = 0;
                                break;
                            }
                        }
                    }
                }
            }
                    file.GetComponent<UnityEngine.UI.Text>().text = bababooey;
        }
    }
    public void exit()
    {
        buttons = GameObject.FindGameObjectsWithTag("read menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
}