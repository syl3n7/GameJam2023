using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class CardsBackZoom : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        gameObject.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), .5f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.transform.DOScale(new Vector3(1, 1, 1), .2f);
    }
}
