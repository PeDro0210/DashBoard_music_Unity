using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;


public class Change_to_title : MonoBehaviour
{
    public string scene_name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(0))
       {
              Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
              RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

              if (hit.collider != null && hit.collider.gameObject == gameObject)
              {
                Debug.Log("Presionado");
                SceneManager.LoadScene(scene_name);
              }
       } 
    }
}

//  I was trying to make something to change scenes, but I haven't look how to completly do it 
