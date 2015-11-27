using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ModelFactory
    {
        public static Board CreateBoard(BoardRequestModel model)
        {
            var board = new Board();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board.Grid[i, j] = new Cell
                    {
                        Piece = model.Board[i][j] != null ? new Piece
                        {
                            Color = (CheckersColor)model.Board[i][j].Color,
                            IsQueen = model.Board[i][j].IsQueen
                        } : null,
                        HorizontalLocation = j,
                        VerticalLocation = i,
                        Color = (i + j) % 2 == 0 ? CheckersColor.White : CheckersColor.Black
                    };
                }
            }

            return board;
        }
    }
}