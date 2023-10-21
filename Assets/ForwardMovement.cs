using UnityEngine;
using System.Collections;

public class ForwardMovement : MonoBehaviour
{
    float timer = 0.0f;
    float transition = 2.3f;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > transition)
        {
            transform.Translate(-(Time.deltaTime * 7.5f), 0, 0);
            if (timer > (transition + 4)) 
            {
                transition = transition + 6.2f;
            
            }
        }
        else
        {
            transform.Translate(-(Time.deltaTime * 100), 0, 0);
        }
    }
}
