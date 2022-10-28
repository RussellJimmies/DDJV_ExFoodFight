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

        /*
        accumulateurTemps += Time.fixedDeltaTime; //Ajoute 1/30 de sec

        if (accumulateurTemps > temps)
        {
            //Line explanation 43:00
            // make a boulet, at the position of Source, no rotation
            float largeur = Random.Range(-limite, limite);
            Vector3 delta = new Vector3(largeur, 0.0f, 0.0f);
            GameObject vilain = Instantiate(bouffe, transform.position + delta, Quaternion.identity);
            //vilain.transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f), 90.0f); //Essieu de la rotation est un vecteur qui sort de l'écran
            accumulateurTemps = 0.0f;
            float ratio = (Time.time + 5.0f) / 5.0f; //Au temps 0 du jeu
            temps = Random.Range(1.0f,  4.0f);
        }
        */
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
