using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    public GameObject acteur;
    public LayerMask masqueRayon;
    private Rigidbody2D rg;
    private TargetJoint2D tj;
    // Start is called before the first frame update
    void Start()
    {
        rg = acteur.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Acteur"))
        {
            Destroy(this.gameObject);
            rg.AddForce(new Vector2(5.0f, 0.0f), ForceMode2D.Impulse);
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Environnement"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            //tj = this.gameObject.GetComponent<TargetJoint2D>();
            Debug.Log("DON'T MIND IF I DO!");
            Destroy(this.gameObject.GetComponent<TargetJoint2D>());

        }

    }
}
