using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';

        public char Validate(char[,] gameBoard)
        {
            var currentWinningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowInVerticalColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            return currentWinningSymbol;
        }

        private static char CheckForThreeInARowInVerticalColumn(char[,] gameBoard)
        {
            if (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X') { return 'X'; }
            if (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X') { return 'X'; }
            if (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X') { return 'X'; }   

                return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            if (gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X') { return 'X'; }

            if (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X') { return 'X'; }

            if (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X') { return 'X'; }
        

            return SymbolForNoWinner;
        }
        
        
       
        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            if (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X') { return 'X'; }

            if (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X') { return 'X'; }


            return SymbolForNoWinner;
        }
       
       
    }
}
