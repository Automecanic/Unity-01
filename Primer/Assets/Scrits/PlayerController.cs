
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //referencies, es poden poser les que es vulgue.
    [Range(0, 20), SerializeField] private float speed = 20f;
    private float turnSpeed=45f;
    public float horizontalImput, verticalInput;

    // Start is called before the first frame update
    // en aquest cas no fa falta el metode start().
    /* void Start()
    {
        //Debug.Log("Inicia el programa el objeto " + gameObject.name);
    } */

    // Update is called once per frame
    void Update()
    {
      // recupera els valor de les variables horizontal ja programades en project-settings
      horizontalImput=Input.GetAxis("Horizontal");
      verticalInput=Input.GetAxis("Vertical");

      
      //S=s0*V*T*(direction)
      transform.Translate(speed*Time.deltaTime*Vector3.forward*verticalInput);
      transform.Rotate(turnSpeed*Time.deltaTime*Vector3.up*horizontalImput);

      

      
       
        //marxa avant---->
       /*  if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.2f);
            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0f, 0.4f, 0f, Space.Self);
            }
             if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -0.4f, 0f, Space.Self);
        }
        }
        //marxa atras----->
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            transform.Translate(0, 0, -0.2f);
           if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
            {
                // transform.Translate(Vector3.right);
                transform.Rotate(0f, 0.4f, 0f, Space.Self);
            }
             if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -0.4f, 0f, Space.Self);
        }

        } */
       
    }
}
