using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Animus.Scene
{
    abstract public class GameState : IGameState
    {
        protected MainGame mainGame;
        public Scene CurrentScene { get; set; }

        public GameState(MainGame pGame)
        {
            mainGame = pGame;
        }

        virtual public void ChangeScene(Scene pScene)
        {
            CurrentScene = pScene;
            if (CurrentScene != null)
            {
                CurrentScene.UnLoad();
            }

            CurrentScene.Load();
        }
    }
}
