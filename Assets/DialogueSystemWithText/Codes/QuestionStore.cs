using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using DialogueSystemWithText;
using DialogueInterface;

public class QuestionStore: MonoBehaviour
{
  public static string[,] qaData = { {"(B1, noun) – вызов, сложность", "challenge", "0"},
			                         {"(B1, noun) – польза, выгода", "benefit", "0"},
			                         {"(B2, noun) – решение (проблемы)", "solution", "0"},
			                         {"", "", ""},
			                         {"", "", ""},
			                         {"", "", ""},
			                         {"", "", ""},
					                 {"", "", ""},
					                 {"", "", ""},
					                 {"", "", ""},
					                 {"", "", ""},
					                 {"", "", ""},
					                 {"", "", ""},
	                               };
}