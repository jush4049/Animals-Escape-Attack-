using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GamePauseOn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    [SerializeField] private float rotationLimit = 40;
    [SerializeField] private float rotationSpeed = 15;

    private bool rotate = false;

    public GameObject OptionPanel;
    public GameObject PlayerUI;

    void Start()
    {
        OptionPanel.SetActive(false);
    }
    void FixedUpdate()
    {
        float targetRotate = rotate ? rotationLimit : 0f;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(targetRotate, 0, 0);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * rotationSpeed);
    }

    public void PasueOn()
    {
        Time.timeScale = 0;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotate = false;
        PasueOn();
        OptionPanel.SetActive(true);
        PlayerUI.SetActive(false);
    }
}