using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1), Time.deltaTime * 100f);
        transform.Translate(new Vector3(0, Time.deltaTime * 10f, 0));
    }
}
