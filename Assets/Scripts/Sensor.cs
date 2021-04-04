using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    Collider sensor;
    [SerializeField] string tag;
    public bool isDetecting;
    GameObject objectToFind;
    // Start is called before the first frame update
    void Start()
    {
        sensor = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (objectToFind == null)
        {
            isDetecting = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag))
        {
            isDetecting = true;
            objectToFind = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tag))
        {
            isDetecting = false;
            objectToFind = null;
        }
    }
}
