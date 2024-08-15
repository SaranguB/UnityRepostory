using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScipt : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public String scene1;
    public String scene2;
    public String scene3;

    void Start()
    {
        button1.onClick.AddListener(() => OnbuttonClick(scene1));
        button2.onClick.AddListener(() => OnbuttonClick(scene2));
        button3.onClick.AddListener(() => OnbuttonClick(scene3));
      
    }

    void OnbuttonClick(String scene)
    {
        SceneManager.LoadScene(scene);
    }

}
