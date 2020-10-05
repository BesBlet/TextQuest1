using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea(15,50)]
    public string content;
    public string title;
    
    public Step[] nextSteps;
    public Sprite nextImage;

}
