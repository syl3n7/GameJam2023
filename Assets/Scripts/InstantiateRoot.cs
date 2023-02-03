using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateRoot : MonoBehaviour
{
    public Rigidbody body;
    public Transform panel;
    public Button Spawn;
    private void Start()
    {
        Spawn.onClick.AddListener(() =>Instantiate(body, panel, true));
    }

    void Update()
    {
        
    }
}
