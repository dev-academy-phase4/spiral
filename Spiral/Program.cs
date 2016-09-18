﻿using System;
using System.Collections.Generic;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            var obstacles = new List<Obstacle> { new Obstacle(1, 1) };

            Board board;
            try
            {
                board = new Board(3, 3, obstacles);
            }
            catch(System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("An error prevented the game board from being created.");
                Console.ReadLine();
                return;
            }
            board.Update();
            Console.Clear();
            Console.Write(board);

            string key = "";
            while((key = Console.ReadKey(true).KeyChar.ToString()) != "q")
            {
                Console.WriteLine(key);
                switch(key)
                {
                    case "w":
                        board.MovePlayer("n");
                        break;

                    case "s":
                        board.MovePlayer("s");
                        break;

                    case "a":
                        board.MovePlayer("w");
                        break;

                    case "d":
                        board.MovePlayer("e");
                        break;
                }
                board.Update();
                Console.Clear();
                Console.Write(board);
            }
        }
    }
}
