using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatefloor : MonoBehaviour
{
    float degrees = 90;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 to = new Vector3(degrees, 0, 0);

        transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);

    }
}
