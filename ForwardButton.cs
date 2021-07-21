using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;

//IPointerDownHandler, IPointerUpHandler
public class ForwardButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static ForwardButton instance = null;

    CarUserControl car;

    void Awake()
    {
        if (instance == null)
            instance = this;

    }

    public void SetPlayer(GameObject player)
    {
        car = player.GetComponent<CarUserControl>();
    }

    public void OnPointerDown(PointerEventData evenData)
    {
        car.Forward();
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        car.PointerUP();
    }




}
