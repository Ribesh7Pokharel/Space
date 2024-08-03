using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
	public Transform orbitCenter; // The center of the orbit (the Sun)
	public float orbitSpeed = 10f; // Speed of the orbit

	// Start is called before the first frame update
	void Start()
    {
		// Find all GameObjects with the tag "Sphere"
		GameObject[] spheres = GameObject.FindGameObjectsWithTag("Sphere");

		// Iterate through each sphere and set its parent to the current GameObject
		foreach (GameObject sphere in spheres)
		{
			sphere.transform.SetParent(transform);
		}

	}

    // Update is called once per frame
    void Update()
    {
		if (orbitCenter != null)
		{
			// Rotate around the orbitCenter's position on the Y axis at orbitSpeed
			transform.RotateAround(orbitCenter.position, Vector3.up, orbitSpeed * Time.deltaTime);
		}
	}
}
