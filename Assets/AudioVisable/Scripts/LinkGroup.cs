using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkGroup : MonoBehaviour
{
    public Transform link1;
    public Transform link2;
    private LineRenderer line;
    private void Awake()
    {
        line = GetComponent<LineRenderer>();   
    }
    private void Start()
    {
        if(transform.position.x > 0)
            transform.localRotation = Quaternion.Euler(0, 0, Mathf.Asin(transform.position.y / Mathf.Sqrt(transform.position.x * transform.position.x + transform.position.y * transform.position.y)) * Mathf.Rad2Deg - 45);
        else
            transform.localRotation = Quaternion.Euler(0, 0, Mathf.Asin(-transform.position.y / Mathf.Sqrt(transform.position.x * transform.position.x + transform.position.y * transform.position.y)) * Mathf.Rad2Deg + 135 );
    }
    private void Update()
    {
        line.SetPosition(0, link1.position);
        line.SetPosition(1, link2.position);
    }
}
