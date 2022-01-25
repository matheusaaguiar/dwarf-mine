using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public GameObject m_mine_preview;

    public void BuildRequested()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 previewPos = Camera.main.ScreenToWorldPoint(mousePos);
      
        previewPos.z = 0.0f;

        Instantiate(m_mine_preview, previewPos, Quaternion.identity);

        Debug.Log("Build Button Pressed!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
