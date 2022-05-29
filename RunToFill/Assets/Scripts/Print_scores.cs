using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print_scores : MonoBehaviour
{
    
    public Text scr_text;
    public Text obj_text;

    void Start()
    {
        scr_text.text = ((int)Point_System.point).ToString();
        obj_text.text = ((int)Point_System.objects).ToString();
        
    }

    
    void Update()
    {
        
    }


}
