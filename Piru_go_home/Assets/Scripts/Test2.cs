using UnityEngine;

public class Test2 : MonoBehaviour


{

   public Vector3 direccion; //variable Direccion

   public float speed=1; //Variable Velocidad

   int vida = 1; //metodo usado para disminuir  Variables de vida

   float energia = 0.0f;  //metodo usado para subir Variables de vida
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(direccion);
    }

    
    void subirvida()

    {
      energia += Time.deltaTime;
      Debug.Log(energia);
    }

      void mover() //controla movimiento y velocidad
    {
        energia += Time.deltaTime;
        transform.position += new Vector3(0.1f,0,0) * speed * Time.deltaTime;
        
    }

    
    void Quitarvida()

    {
      vida-=1;
      Debug.Log(vida);
    }

}