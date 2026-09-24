using UnityEngine;
using System.Collections;


public class Test : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float rotSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        if ( target == null) return;
        var dir = target.position - this.transform.position;
        var angle = Mathf.Atan2(dir.x, dir.z);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
        Quaternion.Euler(0,angle,0), 
        Time.deltaTime * rotSpeed);

        var dot = Vector3.Dot(transform.forward.normalized, dir.normalized);
        Debug.Log($"Dot{dot}");
    }
}
