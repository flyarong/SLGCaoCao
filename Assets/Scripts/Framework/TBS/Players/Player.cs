﻿using Framework.TBS.Grid;
using UnityEngine;

namespace Framework.TBS.Players
{
    /// <summary>
    /// Class represents a game participant.
    /// </summary>
    public abstract class Player : MonoBehaviour
    {
        public int PlayerNumber;
        /// <summary>
        /// Method is called every turn. Allows player to interact with his units.
        /// </summary>         
        public abstract void Play(CellGrid cellGrid);
    }
}