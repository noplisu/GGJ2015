using UnityEngine;
using System.Collections;

public class ActivatorDelayed : Activator {

	public bool activated = false;
	MeshRenderer renderer;
	public Material inactiveMaterial;
	public Material activatedMaterial;
	float delay = 0;
	public float delayAdded = 0;

	void Start()
	{
		renderer = GetComponent<MeshRenderer> ();
	}

	void FixedUpdate()
	{
		if (delay > 0) {
			activated = true;		
		} else {
			activated = false;
		}
		if (activated) {
			renderer.material = activatedMaterial;
		} else {
			renderer.material = inactiveMaterial;
		}
		delay -= Time.deltaTime;
	}

	void OnTriggerStay(Collider other)
	{
		delay = delayAdded;
	}

	public override bool active()
	{
		return activated;
	}
}
