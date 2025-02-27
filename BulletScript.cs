using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public Vector3 bulletMovement;
    public float bulletTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Transform>().position += bulletMovement;

        bulletTimer += Time.deltaTime;

        if (bulletTimer >= 1f)
        {
            Destroy(gameObject);

        }



    }
}
