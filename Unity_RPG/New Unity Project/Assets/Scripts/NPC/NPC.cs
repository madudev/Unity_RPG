using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{   

    public float speed;

    private int index;

    public List<Transform> paths = new List<Transform>();

    // Start is called before the first frame update
    void Update()
    {
        if (index < paths.Count)
        {
            transform.position = Vector2.MoveTowards(transform.position, paths[index].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, paths[index].position) < 0.1f)
            {
                index++;
            }
        }
        else
        {
            index = 0;
        }
    }
}
