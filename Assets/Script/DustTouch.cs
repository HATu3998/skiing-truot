using UnityEngine;

public class DustTouch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] ParticleSystem dust;
    [SerializeField] Rigidbody2D rb;

    private bool wasInAir = false;
    private void Start()
    {
        dust.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground") && wasInAir && Mathf.Abs(rb.linearVelocity.y) > 1f)
        {
            dust.Play();
            wasInAir = false;
        }
    }
     void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            wasInAir = true;
            dust.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }
}
