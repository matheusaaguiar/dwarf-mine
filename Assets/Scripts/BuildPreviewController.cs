using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildPreviewController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Build Preview positioned at: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 mousePos = Input.mousePosition;
        Vector3 previewPos = Camera.main.ScreenToWorldPoint(mousePos);
        previewPos.z = 0.0f;

        transform.position = previewPos;
    }
}
