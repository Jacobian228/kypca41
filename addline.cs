using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class addline : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject main_menu;
    public GameObject fiooo;
    public GameObject kolvooo;
    public GameObject ageees;
    public string path;
    string depart;
    string addedline;
    public UnityEngine.UI.Text inputline;
    public UnityEngine.UI.Text input1;
    public UnityEngine.UI.Text input2;
    public UnityEngine.UI.Text input3;
    public UnityEngine.UI.Text input4;
    public UnityEngine.UI.Text input5;
    public UnityEngine.UI.Text input6;
    public UnityEngine.UI.Text input7;
    public UnityEngine.UI.Text input8;
    public UnityEngine.UI.Text input9;
    public UnityEngine.UI.Text input10;
    string fio;
    public UnityEngine.UI.Text inputname;
    string amount;
    public UnityEngine.UI.Text inputcount;
    public UnityEngine.UI.Text inputdepart;
    public void newline()
    {
        path = inputline.text.ToString();
        //if (File.Exists(path))
        {
            addedline = depart + " " + fio + " " + amount + " : ";
            if (amount == "10")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
                addedline += input6.text.ToString() + " ";
                addedline += input7.text.ToString() + " ";
                addedline += input8.text.ToString() + " ";
                addedline += input9.text.ToString() + " ";
                addedline += input10.text.ToString() + " ";
            }
            if (amount == "9")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
                addedline += input6.text.ToString() + " ";
                addedline += input7.text.ToString() + " ";
                addedline += input8.text.ToString() + " ";
                addedline += input9.text.ToString() + " ";
            }
            if (amount == "8")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
                addedline += input6.text.ToString() + " ";
                addedline += input7.text.ToString() + " ";
                addedline += input8.text.ToString() + " ";
            }
            if (amount == "7")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
                addedline += input6.text.ToString() + " ";
                addedline += input7.text.ToString() + " ";
            }
            if (amount == "6")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
                addedline += input6.text.ToString() + " ";
            }
            if (amount == "5")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
                addedline += input5.text.ToString() + " ";
            }
            if (amount == "4")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
                addedline += input4.text.ToString() + " ";
            }
            if (amount == "3")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
                addedline += input3.text.ToString() + " ";
            }
            if (amount == "2")
            {
                addedline += input1.text.ToString() + " ";
                addedline += input2.text.ToString() + " ";
            }
            if (amount == "1")
            {
                addedline += input1.text.ToString() + " ";
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(""+addedline);
            }
        }
        exit();
    }
    public void department()
    {
        depart= inputdepart.text.ToString();
        fiooo.SetActive(true);
    }
    public void name()
    {
        fio = inputname.text.ToString();
        fio = fio.Replace(" ","");
        kolvooo.SetActive(true);
    }
    public void count()
    {
        amount = inputcount.text.ToString();
        if (amount=="9" || amount=="10" || amount=="1" || amount == "2" || amount == "3" || amount == "4" || amount == "5" || amount == "6" || amount == "7" || amount == "8")
        {
            ageees.SetActive(true);
        }
        else
        {
            exit();
        }
    }
    public void exit()
    {
        fiooo.SetActive(false);
        kolvooo.SetActive(false);
        ageees.SetActive(false);
        buttons = GameObject.FindGameObjectsWithTag("generation menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        main_menu.SetActive(true);
    }
}