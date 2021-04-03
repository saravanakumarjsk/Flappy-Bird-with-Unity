using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float newPipeWaitTime = 1;
    private float timeCoutner = 0;
    public GameObject pipe;
    public float height = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCoutner > newPipeWaitTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15);
            timeCoutner = 0;
        }

        timeCoutner += Time.deltaTime;
    }
}
