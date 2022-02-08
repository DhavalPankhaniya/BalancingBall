using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public GameManager gameManager;
    public Camera cam;
    private int count;
    private Text lives;
    public Text countText;
    public GameObject gameOverUI;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
        Time.timeScale = 1;
        count = 0;
        lives.text = GameManager.lives.ToString();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Vector3 tempTarget = Input.GetAxis("Vertical") * cam.transform.forward * speed + Input.GetAxis("Horizontal") * speed * cam.transform.right;
        rb.AddForce(tempTarget);
        if(transform.position.y < 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            if(GameManager.lives > 0) {
                GameManager.lives -= 1;
                Debug.Log("Attempts left: " + GameManager.lives);     
                lives.text = GameManager.lives.ToString();       
            } else {
                Debug.Log("Game Over");
                gameOverUI.SetActive(true);
                GameManager.lives = 3;
                SceneManager.LoadScene(1);
                // gameManager.EndGame();

            } 
        }
	}
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Pick Up")) {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "SCORE: " + count.ToString();
        }
    }
}
