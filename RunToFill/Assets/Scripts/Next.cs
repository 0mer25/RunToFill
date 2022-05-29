using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Go_To_Next(int index) 
    {
        SceneManager.LoadScene(index);
    }  

    public void Change_Char(int x)
    {
        mmm.charr = x;
    }

    
}
