using UnityEngine;
using System.Collections;

public class ActivatorOnStay : Activator {

	public bool activated = false;
	MeshRenderer renderer;
	public Material inactiveMaterial;
	public Material activatedMaterial;

	void Start()
	{
		renderer = GetComponent<MeshRenderer> ();
	}

	void FixedUpdate()
	{
		if (activated) {
			renderer.material = activatedMaterial;
		} else {
			renderer.material = inactiveMaterial;
		}
	}

	void OnTriggerStay(Collider other)
	{
			activated = true;
	}
	
	void OnTriggerExit(Collider other)
	{
			activated = false;
	}

	public override bool active()
	{
		return activated;
	}
}
