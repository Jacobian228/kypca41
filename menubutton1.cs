using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



public class menubutton1 : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject canvas;
    public GameObject generation_menu;
    public GameObject read_menu;
    public GameObject add_menu;
    public GameObject baby_menu;
    public GameObject adult_menu;
    public GameObject delete_menu;
    public GameObject edit_menu;
    public void menu1(){
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        generation_menu.SetActive(true);
        //var genmenu = Instantiate(generation_menu,new Vector3(560,300,0), Quaternion.identity, canvas.transform);
    }
    public void menu2()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        read_menu.SetActive(true);
        //var readmenu = Instantiate(read_menu, new Vector3(560, 300, 0), Quaternion.identity, canvas.transform);
    }
    public void menu3()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        baby_menu.SetActive(true);
        //var readmenu = Instantiate(read_menu, new Vector3(560, 300, 0), Quaternion.identity, canvas.transform);
    }
    public void menu4()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        adult_menu.SetActive(true);
        //var readmenu = Instantiate(read_menu, new Vector3(560, 300, 0), Quaternion.identity, canvas.transform);
    }
    public void menu5()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        delete_menu.SetActive(true);
        //var readmenu = Instantiate(read_menu, new Vector3(560, 300, 0), Quaternion.identity, canvas.transform);
    }
    public void menu6()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        add_menu.SetActive(true);
    }
    public void menu7()
    {
        buttons = GameObject.FindGameObjectsWithTag("main menu");
        foreach (GameObject i in buttons)
        {
            i.SetActive(false);
        }
        edit_menu.SetActive(true);
    }
}
