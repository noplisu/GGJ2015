using UnityEngine;
using System.Collections;

public abstract class Activator : MonoBehaviour {
	public Material activatedMaterial;
	public Material inactiveMaterial;
	public abstract bool active ();
}
