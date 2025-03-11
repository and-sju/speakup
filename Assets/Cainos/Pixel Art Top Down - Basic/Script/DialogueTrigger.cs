using UnityEngine;
using DialogueSystemWithText;

namespace DialogueInterface
{

public class DialogueTrigger: MonoBehaviour
{

[SerializeField] DialogueUIController _dialogueUIController;

  void OnCollisionEnter2D(Collision2D collision)
  {
  	_dialogueUIController.ShowDialogueUI();
  	Debug.Log("text text text");
  }
}
}