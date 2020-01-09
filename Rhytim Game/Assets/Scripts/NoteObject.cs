using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    bool canBePressed = false;

    public float beatTempo;
    public KeyCode keyPressed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, 0f, beatTempo * Time.deltaTime);

        if(Input.GetKeyDown(keyPressed))
        {
            if (canBePressed)
                Destroy(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button")
        {
            canBePressed = false;
        }
    }
}
