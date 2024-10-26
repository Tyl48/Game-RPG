using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private float parallaxEffect;
    private GameObject cam;
    private float xPosition;
    private float lenght;
    void Start()
    {
        cam = GameObject.Find("Main Camera");

        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
        xPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToMove = cam.transform.position.x * parallaxEffect;
        float distanceToMoved = cam.transform.position.x * (1-parallaxEffect);    

        transform.position = new Vector3(xPosition + distanceToMove, transform.position.y);

        if (distanceToMoved > xPosition + lenght)
            xPosition = xPosition + lenght;
        else if (distanceToMoved < xPosition - lenght)
            xPosition = xPosition - lenght;


    }
}
