using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 50;
    public GameObject focalpoint;
    /*public GameObject enemy;
    public GameObject colvalue;*/
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalpoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalinput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalpoint.transform.forward * speed * verticalinput);
    }
}
