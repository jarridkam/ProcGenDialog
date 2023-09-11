using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ProcgenDialog
{
    public class Dialog
    {
        public Dialog() { }
        public Greeting[] greetings;
    }

    public class DialogComponent
    {
        public string text;
        public int importance;
    }
    public class Greeting : DialogComponent
    {
        public Greeting(Statement statement)
        {
            text = statement.text;
        }
    }
    public class Topic:DialogComponent
    {
        public Topic(Statement statement)
        {
            text = statement.text;
            
        }
        public Topic(string text)
        {
            this.text = text;
        }

        public string response;
    }
    public class MultipleChoice
    {
        public MultipleChoice(Choice[] choices)
        {
            this.choices = choices;
        }

        public Choice[] choices;
        
    }
    public class Choice:DialogComponent
    {
        public Choice(Statement statement, Statement response)
        {
            text = statement.text;
            this.response = response.text;
        }
        public string response;
    }
    public class Response:DialogComponent
    {
        public Response(Statement statement)
        {
            text = statement.text;
        }
        public Response(Statement statement, MultipleChoice multipleChoice)
        {
            text = statement.text;
            this.multipleChoice = multipleChoice;
        }

        public MultipleChoice multipleChoice = null;

    }
    public struct Statement
    {
        public string text { get; set; }

        public Statement(string text)
        {
            this.text = text;
        }

        public void ApplyReplacements(Dictionary<string, string> replacements)
        {
            foreach (var kvp in replacements)
            {
                text = Regex.Replace(text, (kvp.Key), kvp.Value);
            }
        }
    }
}
