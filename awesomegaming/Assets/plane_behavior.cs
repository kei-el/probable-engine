using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_behavior : MonoBehaviour {
  private Vector3 m_pushingForce = new Vector3(1,1,1);
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision col) {
        print("Plane Collided!!!");
        
        Vector3 direction = col.contacts[0].point - transform.position;
        direction = -direction.normalized;
        GetComponent<Rigidbody>().AddForce(direction * 3f);
    }
}
