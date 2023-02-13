using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeController : MonoBehaviour
{
    public int speed;
    public int speedTurn;

    // Start is called before the first frame update
    void Start()
    {

        gameObject.AddComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().mass = 2000;

        //Debug.Log(gameObject.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
        //transform.Translate(Vector3.right * Time.deltaTime * speedTurn * Input.GetAxis("Horizontal"));
        transform.Rotate(Vector3.up, Time.deltaTime * speedTurn * Input.GetAxis("Horizontal"));

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(new Vector3(0,0,0.01f));
        //transform.Translate(Vector3.forward * 0.01f);

    }
}
