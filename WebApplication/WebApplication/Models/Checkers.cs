using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public enum CheckersColor
    {
        Black,
        White
    }

    public class Cell
    {
        public CheckersColor Color { get; set; }
        public Piece Piece { get; set; }
        public int HorizontalLocation { get; set; }
        public int VerticalLocation { get; set; }
    }

    public class Board
    {
        public Board()
        {
            Grid = new Cell[8, 8];
        }
        public Cell[,] Grid  { get; set; }
    }

    public class Piece
    {
        public bool IsQueen { get; set; }
        public CheckersColor Color { get; set; }
    }
}