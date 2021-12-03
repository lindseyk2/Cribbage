using System;
using Raylib_cs;
using Final_Project.Casting;
using System.Collections.Generic;

namespace Final_Project.Services
{
    public class TurnService
    {
        private bool _playerTurn = true;
        private bool _npcTurn = false;

        public TurnService()
        {

        }

        public void SetPlayerTurn(bool playerTurn)
        {
            _playerTurn = playerTurn;
        }
        public bool IsPlayerTurn()
        {
           return _playerTurn;
        }
        public void EndPlayerTurn()
        {
            _playerTurn = false;
            _npcTurn = true;
        }
        public void SetNPCTurn(bool npcTurn)
        {
            _npcTurn = npcTurn;
        }
        public bool IsNPCTurn()
        {
           return _npcTurn;
        }
        public void EndNPCTurn()
        {
            _npcTurn = false;
            _playerTurn = true;
        }
    }
}