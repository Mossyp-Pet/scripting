using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    //
    public int health = 5;
    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        print(health+=level);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        float speed = 1.2f;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
