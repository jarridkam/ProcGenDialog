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
            Greeting greeting = new Greeting(GenerateStatement());
            Debug.Log(greeting.text);
        }

        public Statement GenerateStatement()
        {
            Statement greeting = new Statement("Hey [player_name]!");
            greeting.ApplyReplacements(ReplacementsUtility.GetStandardReplacements());
            return greeting;
        }
    }
       
}

