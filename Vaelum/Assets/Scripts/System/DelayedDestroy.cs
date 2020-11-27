using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{


    public float deathDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyAfterTime", deathDelay);
    }

    

    void DestroyAfterTime()
    {
        Destroy(gameObject);
    }

}
