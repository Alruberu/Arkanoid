using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class BolinhaKica : MonoBehaviour
{
    public float minV = -5.5f;
    public float maxVelocity = 15f;

    Rigidbody2D rb;

    int score = 0;
    int lives = 3;

    public TextMeshProUGUI scoreTxt;
    public GameObject[] livesImage;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (score == 1080)
        {
            GameWon();
        }

        if(transform.position.y < minV)
        {

            if (lives <= 0)
            {
                GameOver();
            }

            else
            {
            transform.position = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
            lives --;
            livesImage[lives].SetActive(false);
            }

        }
        if(rb.linearVelocity.magnitude > maxVelocity){
            rb.linearVelocity = Vector3.ClampMagnitude(rb.linearVelocity, maxVelocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    { 
        if (collision.gameObject.CompareTag("Tijolo"))
        {
            Destroy(collision.gameObject);
            score += 20;
            scoreTxt.text = score.ToString("0000");
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Morte");
    }

    void GameWon()
    {
        Debug.Log("GameWon chamado");
        SceneManager.LoadScene("Vitoria");
    }

}
