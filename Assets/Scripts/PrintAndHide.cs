using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    int rand;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        print(gameObject.name + ":" + i);
        if (gameObject.tag == "Red" && i >= 100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i >= rand)
        {
            rend.enabled = false;
        }
    }
}
