using UnityEngine;
using DialogueSystemWithText;

namespace DialogueInterface
{

public class DialogueTrigger: MonoBehaviour
{
  public DialogueUIController _dialogueUIController;
  public static string textHeader;
  public static string textBody;
  public static string rightAnswer;
  public static GameObject item;

  /*void Start()
  {
    item = gameObject;
  }*/

  void OnCollisionEnter2D(Collision2D collision)
  {
    item = gameObject;

    int row = 0;

    for(int i=0; i<3; i++)
    {
      if(QuestionStore.qaData[i,2] == "0")
      {
        textBody = QuestionStore.qaData[i,0];
        rightAnswer = QuestionStore.qaData[i,1];
        row = i;
      }
    }
    if(QuestionStore.qaData[row,2] == "0")
    _dialogueUIController.ShowDialogueUI();
  }

  public static void HideScroll()
  {
    Destroy(item);
    Debug.Log("inactivated");
  }
}
}