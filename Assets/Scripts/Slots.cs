using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggablePersonCard draggablePersonCard = dropped.GetComponent<DraggablePersonCard>();
            draggablePersonCard.parentAfterDrag = transform;
        }
    }
}
