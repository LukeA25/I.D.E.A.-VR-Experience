using UnityEngine;
using System.Collections;


public class SpinFree : MonoBehaviour {

	float timer = 0.0f;
    float transition = 2.3f;

	void Update() {
        timer += Time.deltaTime;

        if (timer > transition)
        {
            transform.Rotate(0, -(Time.deltaTime * 5f), 0);
            if (timer > (transition + 4))
            {
                transition = transition + 6.2f;

            }
        }
        else
        {
            transform.Rotate(0, -(Time.deltaTime * 20), 0);
        }
    }
}