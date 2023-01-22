using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatManager : MonoBehaviour
{
    public List<GameObject> meatprefabs;
    public int meatNum;

    public void Start()
    {
        foreach (GameObject x in meatprefabs)
        {
            x.SetActive(false);
        }
        meatNum = GlobalsManager.Instance.SelectedMeat;
        meatprefabs[meatNum].SetActive(true);
    }
}
