using UnityEngine;
using System.Collections;

public class Activable : MonoBehaviour {

	public Activator[] activators;
	Animator animator;
	bool active;
	public int maxFails = 0;
	public bool force = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool active = true;
		int fails = 0;
		for (int i = 0; i<activators.Length; i++) {
			if(!activators[i].active())
			{
				print(activators[i].active());
				fails++;
			}
		}
		if (fails > maxFails)
			active = false;
		print (fails);
		if (force)
			active = true;
		animator.SetBool ("DoorOpen", active);
	}
}
