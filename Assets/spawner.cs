using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public int width = 4;
    public int offset = 10;
    public GameObject boid;
    List<GameObject> boids = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < width; ++i) {
            for (int j = 0; j < width; ++j) {
                Vector3 pos = transform.position + (Vector3.down * offset * i) + (Vector3.right * offset * j);
                GameObject curr_boid = Instantiate(boid, pos, transform.rotation);
                boids.Add(curr_boid);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < boids.Count; ++i)
        {
            for (int j = 0; j < boids.Count; ++j)
            {
                if (i == j) continue;
                Debug.Log(boids[i].transform.position.ToString());
            }
        }
    }
}
