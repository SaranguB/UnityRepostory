using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonScript : MonoBehaviour
{
    public Button Backbutton;
    public String scene;

    void Start()
    {
        Backbutton.onClick.AddListener(OnbuttonClick);
    }

    void OnbuttonClick()
    {
        SceneManager.LoadScene(scene);
    }

}
