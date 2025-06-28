using UnityEngine;
using UnityEngine.SceneManagement;
public class Finnist : MonoBehaviour
{
    [SerializeField] float timeDelays = 2f;
    [SerializeField] ParticleSystem praticleFinist;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  void OnTriggerEnter2D(Collider2D col )
    {
        if (col.tag == "Player")
        {
            Debug.Log("da va cham cot");
            praticleFinist.Play();
            Invoke("LoadScene", timeDelays);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
