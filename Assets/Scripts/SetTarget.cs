using UnityEngine;
using System.Collections;
using UnitySampleAssets.Characters.ThirdPerson;

public class SetTarget : MonoBehaviour {
  SelectCharacter character;
  AICharacterControl agent;

  void Start() {
    character = GetComponent<SelectCharacter>();
  }

  // Update is called once per frame
  void Update () {
    if (Input.GetAxisRaw("Fire2") == 1) {
      Ray ray = camera.ScreenPointToRay(Input.mousePosition);
      RaycastHit hitInfo;
      Physics.Raycast(ray, out hitInfo);
      agent = character.current.GetComponent<AICharacterControl>();
      agent.SetTarget(hitInfo.point);
    }
  }
}
