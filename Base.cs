﻿using System.Windows.Forms;
using RaceGame.Structs;
using RaceGame.Delegates;
using System.Collections.Generic;

namespace RaceGame
{
    public static class Base
    {
        public static Window windowHandle;
        public static Game currentGame;
        public static List<GameTask> gameTasks;
        public static List<DrawInfo> drawInfos;

        public static void Main(string[] Args)
        {
            windowHandle = new Window();
            Application.Run(windowHandle);
        }
    }
}
