using System;

namespace Shopping
{
    public class Number
    {
        const int Five = 5;
        const int Ten = 10;
        const int Fifty = 50;
        const int Hundred = 100;

        const double TenProcent = .1;
        const double TwentyProcent = .2;
        const double ThirdProcent = .33;
        const double SixtyProcent = .66;

        public int TenPiece => Ten;

        public int FivePiece => Five;

        public int FiftyPiece => Fifty;

        public int HundredPiece => Hundred;

        public double TenProcentOff => TenProcent;

        public double TwentyProcentOff => TwentyProcent;

        public double ThirdProcentOff => ThirdProcent;

        public double SixtyProcentOff => SixtyProcent;
    }
}