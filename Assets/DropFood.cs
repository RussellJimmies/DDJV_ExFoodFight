using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropFood : MonoBehaviour
{
    public GameObject dragger;
    private TargetJoint2D tj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {

        //Debug.Log("Yeehaw");
        
        tj = GameObject.Find("Dragger").GetComponent<Dragging>().m_TargetJoint;
        //Debug.Log(tj == null);
        //Debug.Log("Yeehaw");
        if (tj != null)
        {
            Destroy(tj);
            tj = null;
        }
        return;
    }
}
