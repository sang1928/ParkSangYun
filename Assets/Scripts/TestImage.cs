using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class TestImage : MonoBehaviour , IPointerClickHandler, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag�� �Ǿ���");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("��ư�� ������");
    }
}
