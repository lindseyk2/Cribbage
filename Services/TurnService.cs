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

        private bool _startRound = true;

        private bool _endRound = false;

        private bool _playerDeal = true;
        private bool _npcDeal = false;

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
        public void SetStartRound(bool startRound)
        {
            _startRound = startRound;
        }
        public bool IsStartRound()
        {
           return _startRound;
        }
        public void SetEndRound(bool endRound)
        {
            _endRound = endRound;
        }
        public bool IsEndRound()
        {
           return _endRound;
        }
        public void SetPlayerDeal(bool playerDeal)
        {
            _playerDeal = playerDeal;
        }
        public bool IsPlayerDeal()
        {
           return _playerDeal;
        }
        public void SetNPCDeal(bool npcDeal)
        {
            _npcDeal = npcDeal;
        }
        public bool IsNPCDeal()
        {
            return _npcDeal;
        }
    }
}