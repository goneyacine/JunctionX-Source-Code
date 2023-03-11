using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public static MovementManager instance { get; private set; }

    public Transform SelectedObject;
    public bool IsMouseReleased = true;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Update()
    {
        if(SelectedObject != null && !IsMouseReleased)
        SelectedObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
