using UnityEngine;
using System.Collections;
using UnitySampleAssets.Characters.ThirdPerson;

public class SetTarget : MonoBehaviour {
	public AICharacterControl agent;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw ("Fire2") == 1) {
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo;
			Physics.Raycast (ray, out hitInfo);
			agent.SetTarget (hitInfo.point);
		}
	}
}
