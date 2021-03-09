using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    public float deathTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroy", deathTime);
    }


    private void destroy()
    {
        Destroy(gameObject);
    }

}
