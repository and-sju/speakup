using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DialogueSystemWithText;
using DialogueInterface;

public class TextInputValidator : MonoBehaviour 
{

  //public static bool isAnswerRight;

  void Start()
  {
    var input = gameObject.GetComponent<InputField>();
    input.onEndEdit.AddListener(SubmitName);
  }

  private void SubmitName(string text)
  {
  	var input = gameObject.GetComponent<InputField>();
    Debug.Log(text);
    if(text == DialogueTrigger.rightAnswer)
    {
    Debug.Log("answer is right");
    input.text = "";
    for(int i=0; i<3; i++)
    {
      if(QuestionStore.qaData[i,0] == DialogueTrigger.textBody && QuestionStore.qaData[i,1] == DialogueTrigger.rightAnswer)
        QuestionStore.qaData[i,2] = "1";
    }
    DialogueTrigger.HideScroll();
    }
    else
    input.text = "";
  }

}