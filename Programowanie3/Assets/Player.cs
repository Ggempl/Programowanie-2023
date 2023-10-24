using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // modyfikator dost�pu private/public
    public int count = 0;
    public float moveSpeed = 5;
    // Komentarz
    // Start is called before the first frame update
    void Start()
    {
        //typ nazwa = warto�� pocz�tkowa
        //float testFloat = 1f;  
    }

    // Update is called once per frame
    void Update()
    {
        //mno�ymy przez Time.deltaTime �eby zamieni� pr�dko�� na klatk�
        //na pr�dko�� na sekund�

        transform.Rotate(0, 60 * Time.deltaTime, 0);
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * moveSpeed * Time.deltaTime,0,0);
    }
}
