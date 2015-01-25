using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public abstract class Activator : MonoBehaviour {
	public Material activatedMaterial;
	public Material inactiveMaterial;
	public abstract bool active ();
}
