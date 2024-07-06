using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class custom_behavior : MonoBehaviour {
    public Color m_notMouseOverColor;

    private Color m_mouseOverColor = Color.red;
    private MeshRenderer m_Renderer;
    private float movementSpeed = 2f;

    // Start is called before the first frame update
    void Start() {
        m_Renderer = GetComponent<MeshRenderer>();
        m_Renderer.material.color = m_notMouseOverColor;
    }

    // Update is called once per frame
    void Update() {
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");
        // transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
    }

    void OnMouseOver() {
        m_Renderer.material.color = m_mouseOverColor;
    }

    void OnMouseExit() {
        m_Renderer.material.color = m_notMouseOverColor;
    }

    void OnTriggerEnter(Collider other) {
        movementSpeed = movementSpeed * -1;
    }
}
