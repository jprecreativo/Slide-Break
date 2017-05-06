using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    private Rigidbody rigidBody;
    private bool juegoIniciado;
    private Vector3 posInicial;
    private Transform barra;

    private void Awake()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        barra = transform.parent;
    }

    private void Start ()
    {
        juegoIniciado = false;
        posInicial = this.transform.position;
	}
	
	private void Update ()
    {
		if(!juegoIniciado && Input.GetButtonDown("Fire1"))
        {
            juegoIniciado = true;

            this.transform.SetParent(null);   // Ya no somos hijo de la barra, nos movemos independientemente.
            rigidBody.isKinematic = false;

            float velocidadInicial = VariablesGlobales.VELOCIDAD_PELOTA;
            float desfase = VariablesGlobales.DESFASE;
            float valorX = (Input.GetAxisRaw("Horizontal") * velocidadInicial + desfase) / 2;
            Vector3 vectorFuerzas = new Vector3(valorX, velocidadInicial, 0);

            rigidBody.AddForce(vectorFuerzas);
        }
	}

    public void pararPelota()
    {
        rigidBody.isKinematic = true;
        rigidBody.velocity = Vector3.zero;   // Vector 3 con (0, 0, 0).
    }

    public void resetearPelota()
    {
        this.transform.position = posInicial;
        this.transform.SetParent(barra);   // Volvemos a ser hijos de la barra.
        this.pararPelota();

        juegoIniciado = false;
    }
}
