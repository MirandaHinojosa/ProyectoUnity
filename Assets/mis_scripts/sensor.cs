using UnityEngine;
public class Sensor : MonoBehaviour {

    Light illum_lgt;
    public GameObject Pantalla_go;
    Renderer rend_pantalla;

    // Use this for initialization
    void Start() {
        illum_lgt = GetComponent<Light> ();
        rend_pantalla = Pantalla_go.GetComponent<Renderer> ();
    }

    public void Encendre()
    {
        if (illum_lgt == null)
            return;
        illum_lgt.enabled = true;
        rend_pantalla.material = new Material(Shader.Find("Unlit/Color"));
    }

    public void Apaga()
    {
        if (illum_lgt == null)
            return;
        illum_lgt.enabled = false;
        rend_pantalla.material = new Material(Shader.Find("Standard"));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        Encendre();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
            return;
        Apaga();
    }
}