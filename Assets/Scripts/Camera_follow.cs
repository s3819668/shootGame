using UnityEngine;

public class Camera_follow : MonoBehaviour {

    // public Transform player;
    public Transform CameraRotation;
    private float Mouse_X;
    private float Mouse_Y;
    public float MouseSensitivity;
    public float xRotation;

    // Update is called once per frame
    void Update () {
        //畫面追隨滑鼠移動
        Mouse_X=Input.GetAxis("Mouse X")*MouseSensitivity*Time.deltaTime;
        Mouse_Y=Input.GetAxis("Mouse Y")*MouseSensitivity*Time.deltaTime;
        xRotation=xRotation-Mouse_Y;
        xRotation=Mathf.Clamp(xRotation,-90f,90f);
        CameraRotation.Rotate(Vector3.up*Mouse_X);
        this.transform.localRotation=Quaternion.Euler(xRotation,0,0);
    }
}