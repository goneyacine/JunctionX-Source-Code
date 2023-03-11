using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateComponentButton : MonoBehaviour
{
    public GameObject ComponentPrefab;

    void CreateComponent()
    {
        GameObject createdObject = 
            Instantiate(ComponentPrefab, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        MovementManager.instance.IsMouseReleased = false;

    }
}
