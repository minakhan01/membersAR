using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAction : MonoBehaviour {

    public GameObject grassCube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        // }
        //if (collision.relativeVelocity.magnitude > 2)
        //    audio.Play();

        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;

        // var cube = GameObject.CreatePrimitive(PrimitiveType.Quad); // Create a quad
        // cube.transform.localScale = new Vector3 (0.3f, 0.3f, 0.05f); // Make the cube smaller
        // cube.transform.position = pos; // Start to drop it in front of the camera
        // cube.GetComponent<Renderer>().material = Resources.Load("Hand_Painted_Grass", typeof(Material)) as Material;
        //cube.renderer.material.mainTexture = texture;
        //cube.AddComponent<Rigidbody>(); // Apply physics
        //Instantiate(explosionPrefab, pos, rot);

        GameObject grass = Instantiate(grassCube, pos, rot);

    }
}
