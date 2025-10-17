using UnityEngine;

public class F2FCameraZoom : MonoBehaviour
{


    public Camera cam;
    public float NormalFOV = 60f;
    public float ZoomFOV = 40f;
    public float ZoomSpeed = 5f;

    private bool Zooming = false;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1)) // if we pressed right mouse 
        {

            Zooming = true;

        }

        if (Input.GetMouseButtonUp(1))
        {

            Zooming = false;

        }

        if (Zooming)
        {

            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, ZoomFOV, ZoomSpeed * Time.deltaTime);

        }
        else
        {

            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, NormalFOV, ZoomSpeed * Time.deltaTime);


        }


    }
}
