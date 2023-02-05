using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotTheChosen : MonoBehaviour
{
    UIAnimations remove;
    private void Start()
    {
        remove = FindObjectOfType<UIAnimations>();   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TU"))
        {
            remove.Remove();
        }
    }
}
