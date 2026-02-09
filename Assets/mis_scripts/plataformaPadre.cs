using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] Transform platform;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals(playerTag))
        {
            collider.gameObject.transform.parent = platform;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag.Equals(playerTag))
        {
            collider.gameObject.transform.parent = null;
        }
    }
}
