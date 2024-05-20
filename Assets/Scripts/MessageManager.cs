using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MessageManager : MonoBehaviour
{
    public TextMeshProUGUI message;

    void Awake()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            message.text = "What a dump, I should get out of here. But first, I need to choose a car.";
        }
        else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 1)
        {
            message.text = "Ok, now to just get the hell out of here...";
        }
    }
}