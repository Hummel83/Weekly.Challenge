﻿using System.Windows.Forms;

namespace TextFileChallenge
{
    internal static class Program
    {
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChallengeForm());
        }
    }
}