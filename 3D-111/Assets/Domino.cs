using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino : MonoBehaviour {
	public Vector3 scale;
	public float mass;
	public float n;
	public GameObject domino;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void createDomino(){
		float off = 0;
		for(int i = 0; i < n;i++){
			off += (scale.y/2)*i+scale.x*i;
			GameObject newDom = Instantiate(domino,transform.position+Vector3.right*off+Vector3.up*scale.y*i*0.5f,Quaternion.identity);
			newDom.transform.localScale = scale * i;
			newDom.GetComponent<Rigidbody>().mass = mass*i;
			newDom.SetActive(true);
		}
	}

}
