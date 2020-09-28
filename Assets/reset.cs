using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public GameObject ball;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<JoystickPlayerExample>())
        {
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            ball.transform.position = startPos;

        }
    }
    public void ResetGame()
    {
        ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        ball.transform.position = startPos;

    }
}
