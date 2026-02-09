using UnityEngine;

public class movil : MonoBehaviour
{
    public GameObject go_pltfm;
    public GameObject go_inicio;
    public GameObject go_fin;

    public float f_velocidad = 4f;
    Vector3 v3_destino;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        v3_destino = go_fin.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        go_pltfm.transform.position = Vector3.MoveTowards(go_pltfm.transform.position,v3_destino,f_velocidad * Time.deltaTime);
        if(Vector3.Distance(go_pltfm.transform.position, go_fin.transform.position) < 0.1f){
            v3_destino = go_inicio.transform.position;
        }
        else if(Vector3.Distance(go_pltfm.transform.position,go_inicio.transform.position) < 0.1f)
        {
            v3_destino = go_fin.transform.position;
        }
    }
}
