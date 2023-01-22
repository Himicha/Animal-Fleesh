using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindManager : MonoBehaviour
{
    public void SetAnimalNum(int animalnum)
    {
        GlobalsManager globals = FindObjectOfType<GlobalsManager>();
        globals.SelectedAnimal = animalnum;
    }
    public void changeScene()
    {
        GlobalsManager globals = FindObjectOfType<GlobalsManager>();
        globals.ChangeScene();
    }
    public void SetAnimalMeat (int meatnum)
    {
        GlobalsManager globals = FindObjectOfType<GlobalsManager>();
        globals.SelectedMeat = meatnum;
    }
}
