using UnityEngine;

public class MovimientoBarra : MonoBehaviour
{
    public float velocidad;
    private Vector3 posInicial;

    private void Start()
    {
        velocidad = 18.5f;
        posInicial = this.transform.position;
    }
	
	private void Update()
    {
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = this.transform.position.x + (movimientoHorizontal * velocidad * Time.deltaTime);
        float posX_Ajustada = Mathf.Clamp(posX, -8, 8);

        this.transform.position = new Vector3(posX_Ajustada, this.transform.position.y, this.transform.position.z);
    }

    public void resetearPos()
    {
        this.transform.position = posInicial;
    }

    private void OnCollisionEnter(Collision pelota)
    {
        Rigidbody rigidBodyPelota = pelota.gameObject.transform.GetComponent<Rigidbody>();

        rigidBodyPelota.AddForce(new Vector3(0, VariablesGlobales.VELOCIDAD_REBOTE_BARRA, 0));
    }
}
