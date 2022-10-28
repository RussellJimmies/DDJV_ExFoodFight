using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject acteur;
    public GameObject bouffe;
    public GameObject prots;
    public float limite = 20.0f;
    private float accumulateurTemps = 0.0f;
    private float temps = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CSpawnFood());
        Instantiate(acteur, new Vector3(7.0f, -0.32f, 1.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {


    }

    public IEnumerator CSpawnFood()
    {
        while(true)
        {
            float largeur = Random.Range(-limite, limite);
            float rdmTime = Random.Range(0.1f, 4.0f);
            Vector3 delta = new Vector3(largeur, -1.0f, 0.0f);
            yield return new WaitForSeconds(rdmTime);
            Instantiate(bouffe, transform.position + delta, Quaternion.identity);
            
        }

    }
}
