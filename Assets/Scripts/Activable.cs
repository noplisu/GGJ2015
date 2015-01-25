using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Activable : MonoBehaviour {

	public Activator[] activators;
	Animator animator;
	bool active;
	public int maxFails = 0;
	public bool force = false;

	public Color color;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		renderer.material.color = color;
		for (int i = 0; i<activators.Length; i++) {
			activators[i].inactiveMaterial.color = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		bool active = true;
		int fails = 0;
		for (int i = 0; i<activators.Length; i++) {
			if(!activators[i].active())
			{
				fails++;
			}
		}
		if (fails > maxFails)
			active = false;
		if (force)
			active = true;
		animator.SetBool ("DoorOpen", active);
	}
}
