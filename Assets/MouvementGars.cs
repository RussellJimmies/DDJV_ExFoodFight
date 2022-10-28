using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouvementGars : MonoBehaviour
{
    private Vector3 mouvement;
    private Rigidbody2D rig;
    public LayerMask masqueRayon;
    // Start is called before the first frame update
    void Start()
    {
        mouvement.z = 0.0f;
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //mouvement.x = Input.GetAxisRaw("Horizontal");
        //mouvement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") == 1 ) {
            rig.AddForce(new Vector2(4.0f, 0.0f));
        }
        else if(Input.GetAxisRaw("Horizontal") == -1)
        {
            rig.AddForce(new Vector2(-4.0f, 0.0f));
        }
        else if (Input.GetAxisRaw("Vertical") == 1)
        {
            rig.AddForce(new Vector2(0.0f, 2.0f));
        }
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            rig.AddForce(new Vector2(0.0f, -2.0f));
            
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Environnement"))
        {
            SceneManager.LoadScene("Niveau1");
        }
    }
}
