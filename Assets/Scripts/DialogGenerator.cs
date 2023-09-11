using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ProcgenDialog
{
    public class DialogGenerator : MonoBehaviour
    {
        

        public void Start()
        {
            Dialog dialog = new Dialog();
            Greeting greeting = new Greeting(GenerateStatement());

            Debug.Log(greeting.text);
           
        }

        private Statement GenerateStatement()
        {
            Statement statement = new Statement("Hey [player_name]! You're a part of [player_faction], aren't you?");
            statement.ApplyReplacements(ReplacementsUtility.GetStandardReplacements());
            return statement;
        }

        
    }

    public class SentenceConstructor
    {
        public string sentenceObject;
        public string verb;
        public string subject;
    }
       
}



