using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmm : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float charr_speed;
    [SerializeField] public Animator anim;
    public int x;
    public static int charr = 0;
    
    void Start()
    {
        rb.velocity = new Vector2(0f , 0f);
    }

    private void Awake() {
        if(charr == 0)
        {
            anim.SetInteger("x" , 0);
        }
        else if(charr == 1)
        {
            anim.SetInteger("x" , 1);
        }
        else if(charr == 2)
        {
            anim.SetInteger("x" , 2);
        }
    }

    
    void Update()
    {
        
    }

    public void Up()
    {
        //transform.position = new Vector3(transform.position.x , transform.position.y + speed , transform.position.z);
        x = 1;
    }

    public void Down()
    {
        //transform.position = new Vector3(transform.position.x , transform.position.y - speed , transform.position.z);
        x = -1;
    }

    public void Exit()
    {
        x = 0;
    }

    public void Check()
    {
        if(x == 1)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y + charr_speed , transform.position.z);
        }
        else if(x == -1)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y - charr_speed , transform.position.z);
        }
    }

    



    

    
    
}
