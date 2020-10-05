using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text contentText;
    public Text titleText;
    public Step startStep;
    public Image contentImage;
    Step currentStep;
    void Start()
    {
        currentStep = startStep;
        contentText.text = startStep.content;
        titleText.text = startStep.title;
        contentImage.sprite = startStep.nextImage;
    }

 
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentStep = currentStep.nextSteps[0];
            contentText.text = currentStep.content;
            titleText.text = currentStep.title;
            contentImage.sprite = currentStep.nextImage;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentStep = currentStep.nextSteps[1];
            contentText.text = currentStep.content;
            titleText.text = currentStep.title;
            contentImage.sprite = currentStep.nextImage;
        }
    }
}
