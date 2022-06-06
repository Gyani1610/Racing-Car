using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed = 30f;
    public float rotspeed = 40f;
    private float InputHorizontal;
    private float InputVertical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * InputVertical);
        InputHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * Time.deltaTime * rotspeed * InputHorizontal);
    }
}
