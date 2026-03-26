using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class tubeGenerator : MonoBehaviour
{
    public GameObject prefabTubo1;
    public GameObject prefabTubo2;
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

    }

}
