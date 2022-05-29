using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Point_System : MonoBehaviour
{
    public static int point;
    public Text score_text;
    public Text objects_text;
    public static int objects;
    public int obj_goal;
    public int score_goal;

    [SerializeField] public AudioSource get_p;
    [SerializeField] public AudioSource lose_p;
    
    void Start()
    {
        point = 0;
        objects = 0;
    }

    
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex != 7)
        {
            if(GameObject.FindGameObjectWithTag("Player") != null)
            {
                point += 1;
                score_text.text = ((int)point).ToString();
                objects_text.text = ((int)objects).ToString();
            }

            if(objects >= obj_goal && point >= score_goal)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else
        {
            if(GameObject.FindGameObjectWithTag("Player") != null)
            {
                point += 1;
                score_text.text = ((int)point).ToString();
                objects_text.text = ((int)objects).ToString();
            }

            if(point >= score_goal)
            {
                score_goal += 5000;
                Point_Movement.speed += 0.01f;
            }
        }
        
    }
    

    
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("artı"))
        {
            objects += 1;
            get_p.Play();
            Destroy(other.gameObject);
        }
        

        if(other.gameObject.CompareTag("eksi"))
        {
            point -= 500;
            lose_p.Play();
            Destroy(other.gameObject);
        }
    }

}
