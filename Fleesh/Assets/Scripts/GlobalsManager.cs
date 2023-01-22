using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalsManager : MonoBehaviour
{
    public static GlobalsManager Instance { get; private set; }

    public int SelectedAnimal;
    public int SelectedMeat;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectAnimal(int animal)
    {
        SelectedAnimal = animal;
    }

    public void Selectmeat(int meat)
    {
        SelectedMeat = meat;
    }
    public void ChangeScene()
    {
        switch (SelectedAnimal)
        {
            case 0:
                SceneManager.LoadScene(2);
                    break;
            case 1:
                SceneManager.LoadScene(3);
                break;
            case 2:
                SceneManager.LoadScene(4);
                break;
            case 3:
                SceneManager.LoadScene(5);
                break;
            case 4:
                SceneManager.LoadScene(6);
                break;
            case 5:
                SceneManager.LoadScene(7);
                break;
            case 6:
                SceneManager.LoadScene(8);
                break;
            case 7:
                SceneManager.LoadScene(9);
                break;
        }
    }
}
