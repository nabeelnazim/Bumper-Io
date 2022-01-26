using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject objectAfterCollision=null;
    public Texture[] texture;
    Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < 0 && objectAfterCollision!=null)
        {
            objectAfterCollision.transform.localScale += gameObject.transform.localScale;
            objectAfterCollision.gameObject.GetComponent<Rigidbody>().mass+=1;
            //To change texture of object after collision
            MeshRenderer mranderer = objectAfterCollision.gameObject.GetComponent<MeshRenderer>();
            int randomtexture = Random.Range(0, texture.Length);
            mranderer.material.SetTexture("_MainTex", texture[randomtexture]);
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy"))
        {
            //Store reference of the object that hit other object
            objectAfterCollision = collision.gameObject;
        }
    }
}
