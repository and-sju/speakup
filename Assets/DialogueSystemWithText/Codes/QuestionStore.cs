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
			                         {"(B2, noun) – уверенность", "confidence", "0"},
			                         {"(B1, verb) – достигать", "achieve", "0"},
			                         {"(B1, verb) – выражать", "express", "0"},
			                         {"(B2, verb) – поддерживать", "maintain", "0"},
					                 {"(B2, adjective) – эффективный", "efficient", "0"},
					                 {"(B2, adjective) – надёжный", "reliable", "0"},
					                 {"(B2, adjective) – трудный, но интересный", "challenging", "0"},
	                               };
}