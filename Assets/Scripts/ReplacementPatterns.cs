using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ProcgenDialog
{
    public class ReplacementsUtility
    {
        public static Dictionary<string, string> GetStandardReplacements()
        {
            return new Dictionary<string, string>
            {
                { ReplacementDialogPatterns.PlayerNamePattern, TestDialogGeneration.testName },
                { ReplacementDialogPatterns.PlayerLocationPattern, TestDialogGeneration.currentLocation.ToString() },
                { ReplacementDialogPatterns.PlayerFactionPattern, TestDialogGeneration.currentFaction.ToString()}
            };
        }
    }
}


