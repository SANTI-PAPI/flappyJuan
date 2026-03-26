using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class tubeGenerator : MonoBehaviour
{
    public GameObject prefabTubo1;
    public GameObject prefabTubo2;
    public GameObject score;
    public float tiempoSpawn = 4f;
    public float espacioEntreTubos = 3f;
    public float alturaMax = 2f;
    public float alturaMin = -2f;
    public float contador = 0f;
   
    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoSpawn)
        {
            GenerarTubo();
            contador = 0f;
        }
    }

    void GenerarTubo()
    {
        float centroY = Random.Range(alturaMin, alturaMax);
        Vector3 topPos = new Vector3(transform.position.x, centroY + espacioEntreTubos / 2f, 0f);
        GameObject tubo2 = Instantiate(prefabTubo2, topPos, Quaternion.identity);
        tubo2.transform.Rotate(0f, 0f, 180f);


        Vector3 bottomPos = new Vector3(transform.position.x, centroY - espacioEntreTubos / 2f, 0f);
        Instantiate(prefabTubo1, bottomPos, Quaternion.identity);


        Vector3 scorePos = new Vector3(transform.position.x + 1.5f, centroY, 0f);
        GameObject trigger = Instantiate(score, scorePos, Quaternion.identity);

        // Ajustar tamaño del collider para cubrir el hueco
        BoxCollider2D col = trigger.GetComponent<BoxCollider2D>();
        col.isTrigger = true;
        col.size = new Vector2(1.5f, espacioEntreTubos); 

    }

}
