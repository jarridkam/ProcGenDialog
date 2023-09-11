using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProcgenDialog
{
    public class TestDialogGeneration
    {
        public static string testName = "Blue";

        public enum TestFaction
        {
            TheKnightsofGoodness,
            TheWizardsOfBadness
        }

        public enum TestLocation
        {
            Cityshire,
            EvilForest
        }

        public static TestFaction currentFaction = TestFaction.TheWizardsOfBadness;
        public static TestLocation currentLocation = TestLocation.Cityshire;
    }
}

