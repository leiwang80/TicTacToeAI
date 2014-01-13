using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Position
    {
        internal int x, y;

        public Position(int aInt1, int aInt2)
        {
            x = aInt1;
            y = aInt2;
        }
    }

    class Game
    {
        internal Player[] players;
        internal int currentID;
        internal bool isPlayerSet;
        internal int winner;
        internal int[,] ticBoard;
        internal List<Position> valuePositions;
        internal Random random;
        internal int AILevel;
        internal bool newStart;


        public Game()
        {
            players = new Player[3];
            players[0] = new Player("", "");
            currentID = 0;
            AILevel = 0;
            isPlayerSet = false;
            newStart = true;

            random = new Random();
            ticBoard = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, {0, 0, 0 } };
            valuePositions = new List<Position>();

            for (int i = 0; i < 3; i++)
                valuePositions.Add(new Position(i, i));
            valuePositions.Add(new Position(0, 2));
            valuePositions.Add(new Position(2, 0));
        }

        public void switchPlayer()
        {
            currentID = currentID % 2 + 1;

            if (players[currentID].isAI)
            {
                Position p = AINextPosition(AILevel);  
                Program.mainForm.AIMove(p);
            }
        }

        public int CheckWinning()
        {
            for (int i = 0; i < 3; i++)
            {
                if (ticBoard[i, 0] != 0 && ticBoard[i, 0] == ticBoard[i, 1] && ticBoard[i, 0] == ticBoard[i, 2])
                    return ticBoard[i, 0];

                if (ticBoard[0, i] != 0 && ticBoard[0, i] == ticBoard[1, i] && ticBoard[0, i] == ticBoard[2, i])
                    return ticBoard[0,i];
            }

            if (ticBoard[0, 0] != 0 && ticBoard[0, 0] == ticBoard[1, 1] && ticBoard[0, 0] == ticBoard[2, 2])
                return ticBoard[0, 0];

            return 0;
        }

        public List<Position> FreePositions()
        {
            List<Position> list = new List<Position>();

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (ticBoard[i, j] == 0)
                        list.Add(new Position(i, j));

            return list;
        }

        public List<Position> FreeValuePositions()
        {
            List<Position> list = new List<Position>();

            foreach (Position p in valuePositions)
                    if (ticBoard[p.x, p.y] == 0)
                        list.Add(p);

            return list;
        }

        public Position RandomNextPostion()
        {
            List<Position> list = FreePositions();

            Position p = list[random.Next(0, list.Count)];
            return p;
        }

        public Position RandomNextValuePostion()
        {
            List<Position> list = FreeValuePositions();

            if (list.Count == 0)
                return new Position(-1, -1);
            else if (list.Count == 1)
                return list[0];
            else
                return list[random.Next(0, list.Count)];
        }

        public Position WinPosition(int ownID)
        {
            List<Position> freePositions = FreePositions();

            foreach (Position p in freePositions)
            {
                if (ticBoard[(p.x+1)%3, p.y] == ownID && ticBoard[(p.x+2)%3, p.y] == ownID)
                    return p;
                if (ticBoard[p.x, (p.y + 1) % 3] == ownID && ticBoard[p.x, (p.y + 2) % 3] == ownID)
                    return p;
                if (p.x == p.y && ticBoard[(p.x + 1) % 3, (p.x + 1) % 3] == ownID && ticBoard[(p.x + 2) % 3, (p.x + 2) % 3] == ownID)
                    return p;
            }
            return new Position(-1,-1);
        }

        public Position OppisiteWinPosition(int ownID)
        {
            Position p;
            int oppositeID = (ownID % 2) + 1;

            p = WinPosition(oppositeID);
            return p;
        }

        public Position AINextPosition(int level)
        {
            Position p;

            if (level == 1)
                p = RandomNextPostion();
            else if (level == 2)
            {
                p = OppisiteWinPosition(currentID);
                if (p.x == -1)
                    p = RandomNextPostion();
            }
            else if (level == 3)
            {
                p = WinPosition(currentID);
                if (p.x == -1)
                {
                    p = OppisiteWinPosition(currentID);
                    if (p.x == -1)
                        p = RandomNextPostion();
                }
            }
            else
            {
                p = WinPosition(currentID);
                if (p.x == -1)
                {
                    p = OppisiteWinPosition(currentID);
                    if (p.x == -1)
                    {
                        p = RandomNextValuePostion();
                        if (p.x == -1)
                            p = RandomNextPostion();
                    }
                }
            }

            return p;
        }

    }
}
