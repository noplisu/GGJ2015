using UnityEngine;
using System.Collections;

public class Activator : MonoBehaviour {

	public bool active = false;
	MeshRenderer renderer;
	public Material inactive;
	public Material activated;

	void Start()
	{
		renderer = GetComponent<MeshRenderer> ();
	}

	void FixedUpdate()
	{
		if (active) {
			renderer.material = activated;
		} else {
			renderer.material = inactive;
		}
	}

	void OnTriggerStay(Collider other)
	{
			active = true;
	}
	
	void OnTriggerExit(Collider other)
	{
			active = false;
	}
}
