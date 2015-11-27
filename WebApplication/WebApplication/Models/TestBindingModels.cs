using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class BoardRequestModel
    {
        public PieceRequestModel[][] Board { get; set; }
        public LocationRequestModel From { get; set; }
        public LocationRequestModel To { get; set; }
    }

    public class PieceRequestModel
    {
        public bool IsQueen { get; set; }
        public int Color { get; set; }
    }

    public class LocationRequestModel
    {
        public int HorizontalLocation { get; set; }
        public int VerticalLocation { get; set; }
    }

    /*
{
    "Board" : [
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, null],
            [null, null, null, null, null, null, null, {
                "IsQueen" : false,
                "Color": 1
            }],
        ],
        "From" : {
            "HorizontalLocation" : 1,
            "VerticalLocation" : 1
        },
        "To" : {
            "HorizontalLocation" : 2,
            "VerticalLocation" : 2
        }
}
    */
}