using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class WheelController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    public bool isSpin = false; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate(); 
    }

    void Rotate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime); 
        if(isSpin ==false && speed > 0)
        {
            StopWheel(); 
        }

    }
    private void StopWheel()
    {
        speed--;
        if (speed <= 0) speed = 0; 
    }
   public void restartSpining()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
