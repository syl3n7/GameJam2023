using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chosen : MonoBehaviour
{
    UIAnimations animations;

    private void Start()
    {
        animations = FindObjectOfType<UIAnimations>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TU"))
        {   
            animations.victoryPanel.DOAnchorPos(new Vector2(0f, 0f), .5f, false).SetEase(Ease.InOutSine);
        }
    }
}
