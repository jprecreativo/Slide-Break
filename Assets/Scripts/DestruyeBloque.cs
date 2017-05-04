using UnityEngine;

public class DestruyeBloque : MonoBehaviour
{
    public GameObject particleSys;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(particleSys, this.transform.position, Quaternion.identity);
    }
}
