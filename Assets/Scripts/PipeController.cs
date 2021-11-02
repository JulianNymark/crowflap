using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float gap_y;
    public float gap_size;
    public GameObject pipe_top;
    public GameObject pipe_bottom;

    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector3(-2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(float gap_y, float gap_size) {
        var pipeHeight = 20f;
        var scaledSize = new Vector3(1, pipeHeight, 0);
        pipe_top.transform.localScale = scaledSize;
        pipe_bottom.transform.localScale = scaledSize;

        pipe_top.transform.localPosition = new Vector3(0, (gap_y + (gap_size/2) + (pipeHeight/2)), 0);
        pipe_bottom.transform.localPosition = new Vector3(0, gap_y - (gap_size / 2) - (pipeHeight/2), 0);
        Debug.Log($"bottom spawned {gap_y}, {gap_size / 2}, {pipeHeight/2}");
    }
}
