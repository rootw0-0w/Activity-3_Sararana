using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
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
}
