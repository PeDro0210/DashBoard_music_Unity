using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_button : MonoBehaviour
{
    public AudioSource music;
    public Animator Anim;
    public KeyCode input_button;


    void Start()
    {

        Anim = GetComponent<Animator>();
        music = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
{


    if (Input.GetMouseButton(0) || Input.GetKey(input_button))

    {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject || Input.GetKey(input_button))
            {
                
                if (!music.isPlaying)
                {   
                    Debug.Log(Anim);
                    Anim.SetBool("Touch", true);
                    music.Play();
                }
            }
            else
            {
                Debug.Log("Hit nothing");
                if (music.isPlaying)
                {   
                    Debug.Log(Anim);
                    Anim.SetBool("Touch", false);
                    music.Stop();
                }
            }
    }
    else
    {
        if (music.isPlaying)
        {   
            Debug.Log(Anim);
            Anim.SetBool("Touch", false);
            music.Stop();
        }
    }
}
}

 