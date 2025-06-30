using UnityEngine;
using UnityEngine.SceneManagement;
public class Crash : MonoBehaviour
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
        if(col.tag == "Ground")
        {
            FindFirstObjectByType<Controller>().CheckBool();
            Debug.Log("da cham vao dau");
            praticleFinist.Play();
            //ham invoke delay thoi gian lai 2s
            Invoke("LoadScene", timeDelays);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
