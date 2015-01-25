using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PermanentUnlock : MonoBehaviour {

	public Activable door;
	bool activated = false;
	MeshRenderer renderer;
	public Material inactiveMaterial;
	public Material activatedMaterial;
	
	void Start()
	{
		renderer = GetComponent<MeshRenderer> ();
		inactiveMaterial.color = door.color;
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
		door.force = true;
	}
}
