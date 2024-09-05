using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButtonSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource buttonHover;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse hovered over button");
        buttonHover.Play();
    }
    
}