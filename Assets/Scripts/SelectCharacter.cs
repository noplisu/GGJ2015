using UnityEngine;
using System.Collections;

public class SelectCharacter : MonoBehaviour {
  public GameObject current = null;

  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    if (Input.GetMouseButton(0)) {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;
      if (Physics.Raycast(ray, out hit)) {
        Transform transform = hit.transform;
        if (transform.tag == "Player") {
          current = transform.gameObject;
        }
      }
    }
  }
}
