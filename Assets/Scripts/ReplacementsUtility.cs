using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using UnityEngine;

namespace ProcgenDialog
{
    public static class ReplacementsUtility
    {
        public static Dictionary<string, string> GetStandardReplacements()
        {
            return new Dictionary<string, string>
            {
                { ReplacementDialogPatterns.PlayerNamePattern, TestDialogGeneration.testName },
                { ReplacementDialogPatterns.PlayerLocationPattern, TestDialogGeneration.currentLocation.ToString() },
                { ReplacementDialogPatterns.PlayerFactionPattern, SpacedEnumValue(TestDialogGeneration.currentFaction)}
            };
        }

        public static string SpacedEnumValue(Enum enumValue)
        {
            string camelCase = enumValue.ToString();
            string spacedValue = Regex.Replace(camelCase, "(\\B[A-Z])", " $1");
            return CustomTitleCase(spacedValue.ToLower());
        }

        public static string CustomTitleCase(string input)
        {
            string titleCased = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

            string[] lowercaseWords = { "Of", "In", "The", "To", "And" }; 

            foreach (string word in lowercaseWords)
            {
                titleCased = titleCased.Replace(" " + word + " ", " " + word.ToLower() + " ");
            }

            return titleCased;
        }
    }
}


