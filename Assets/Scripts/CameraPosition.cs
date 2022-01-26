using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public Transform player=null;
    public float boundX = 2.0f;
    public float boundZ = 1.5f;
    private Vector3 desiredpos;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 delta = Vector3.zero;
        if (player != null)
        {
            float dx = player.position.x - transform.position.x; //player x position - camera x position
            if (dx > boundX || dx < -boundX)
            {
                if (transform.position.x < player.position.x)
                {
                    delta.x = dx - boundX;
                }
                else
                {
                    delta.x = dx + boundX;
                }
            }
            float dz = player.position.z - transform.position.z;
            if (dz > boundZ || dz < -boundZ)
            {
                if (transform.position.z < player.position.z)
                {
                    delta.z = dz - boundZ;
                }
                else
                {
                    delta.z = dz + boundZ;
                }
            }

            //move the camera
            desiredpos = transform.position + delta;
            transform.position = Vector3.Lerp(transform.position, desiredpos, speed);
        }
    }
}
