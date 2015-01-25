using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
  public float speed = 15.0f;

  // Use this for initialization
  void Start () {
  }

  // Update is called once per frame
  void Update () {
    float horizontalAxis = Input.GetAxis("Horizontal");
    float verticalAxis = Input.GetAxis("Vertical");
    float delta = Time.deltaTime;
    float horizontalDistance = speed*delta*horizontalAxis;
    float verticalDistance = speed*delta*verticalAxis;
    float x = transform.position.x;
    float y = transform.position.y;
    float z = transform.position.z;
    x += horizontalDistance;
    z += verticalDistance;
    transform.position = new Vector3(x, y, z);
  }
}
