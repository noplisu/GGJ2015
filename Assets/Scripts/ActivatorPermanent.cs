using UnityEngine;
using System.Collections;

public class ActivatorPermanent : Activator {

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

	void OnTriggerEnter(Collider other)
	{
		 activated = true;
	}

	public override bool active ()
	{
		return activated;
	}
}
