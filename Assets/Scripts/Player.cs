using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] GameObject flameShoot;
    [SerializeField] GameObject sniperShoot;
    [SerializeField] GameObject shotgunShoot;
    
    public GameObject winPanel;
    void Start()
    {
        
    }

     void Update()
    {
       Move();
    }

    void Move() // Input functions for player movement
    {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    void FlameTurret()
    {
        
    }

    void ShotgunTurret()
    {

    }

    void SniperTurret()
    {
        
    }

    void ActivateWinPanel()
    {
        if (winPanel != null)
        {
            winPanel.SetActive(true);

        }
    }
}
