using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.Vehicles.Car;

public class BackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{



    public static BackButton instance = null;

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
        car.Backward();
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        car.PointerUP();
    }


}
