using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    public Vector2 minimum;
    public Vector2 maximum;
    public float smoothing;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothing);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothing);

        transform.position = new Vector3(Mathf.Clamp(posX, minimum.x, maximum.x), Mathf.Clamp(posY, minimum.y, maximum.y), transform.position.z);
    }
}
