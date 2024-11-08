using UnityEngine;

public class ColisionAnimacion : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator del objeto que contiene la animaci�n

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ObjetoColision")) // Comprueba si el objeto que colision� tiene la etiqueta "ObjetoColision"
        {
            animator.SetTrigger("ActivarAnimacion"); // Activa la animaci�n utilizando el disparador "ActivarAnimacion" en el Animator
        }
    }
}