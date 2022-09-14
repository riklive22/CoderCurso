using UnityEngine;


public class TEST : MonoBehaviour
{

    public Vector3 movimiento;

    public Vector3 rotation;



    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(movimiento);
       

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(rotation); 
    }


}
