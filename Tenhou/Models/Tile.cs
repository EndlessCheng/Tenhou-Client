﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenhou.Models
{
    class Tile: IComparable<Tile>
    {
        private int num;
        private bool isTakenAway;

        public int Num
        {
            get
            {
                return num;
            }
        }

        public bool IsTakenAway
        {
            get
            {
                return isTakenAway;
            }
            set
            {
                isTakenAway = value;
            }
        }

        public string Name
        {
            get
            {
                return map[num];
            }
        }

        public Tile(int num)
        {
            this.num = num;
        }

        override public string ToString() {
            return num.ToString();
        }

        public int CompareTo(Tile other)
        {
            return this.num - other.num;
        }

        Dictionary<int, string> map = new Dictionary<int, string>() {
            {0, "1m"}, {1, "1m"}, {2, "1m"}, {3, "1m"}, 
            {4, "2m"}, {5, "2m"}, {6, "2m"}, {7, "2m"}, 
            {8, "3m"}, {9, "3m"}, {10, "3m"}, {11, "3m"}, 
            {12, "4m"}, {13, "4m"}, {14, "4m"}, {15, "4m"}, 
            {16, "5m*"}, {17, "5m"}, {18, "5m"}, {19, "5m"}, 
            {20, "6m"}, {21, "6m"}, {22, "6m"}, {23, "6m"}, 
            {24, "7m"}, {25, "7m"}, {26, "7m"}, {27, "7m"}, 
            {28, "8m"}, {29, "8m"}, {30, "8m"}, {31, "8m"}, 
            {32, "9m"}, {33, "9m"}, {34, "9m"}, {35, "9m"}, 
            {36, "1p"}, {37, "1p"}, {38, "1p"}, {39, "1p"}, 
            {40, "2p"}, {41, "2p"}, {42, "2p"}, {43, "2p"}, 
            {44, "3p"}, {45, "3p"}, {46, "3p"}, {47, "3p"}, 
            {48, "4p"}, {49, "4p"}, {50, "4p"}, {51, "4p"}, 
            {52, "5p*"}, {53, "5p"}, {54, "5p"}, {55, "5p"}, 
            {56, "6p"}, {57, "6p"}, {58, "6p"}, {59, "6p"}, 
            {60, "7p"}, {61, "7p"}, {62, "7p"}, {63, "7p"}, 
            {64, "8p"}, {65, "8p"}, {66, "8p"}, {67, "8p"}, 
            {68, "9p"}, {69, "9p"}, {70, "9p"}, {71, "9p"}, 
            {72, "1s"}, {73, "1s"}, {74, "1s"}, {75, "1s"}, 
            {76, "2s"}, {77, "2s"}, {78, "2s"}, {79, "2s"}, 
            {80, "3s"}, {81, "3s"}, {82, "3s"}, {83, "3s"}, 
            {84, "4s"}, {85, "4s"}, {86, "4s"}, {87, "4s"}, 
            {88, "5s*"}, {89, "5s"}, {90, "5s"}, {91, "5s"}, 
            {92, "6s"}, {93, "6s"}, {94, "6s"}, {95, "6s"}, 
            {96, "7s"}, {97, "7s"}, {98, "7s"}, {99, "7s"}, 
            {100, "8s"}, {101, "8s"}, {102, "8s"}, {103, "8s"}, 
            {104, "9s"}, {105, "9s"}, {106, "9s"}, {107, "9s"}, 
            {108, "1z"}, {109, "1z"}, {110, "1z"}, {111, "1z"}, 
            {112, "2z"}, {113, "2z"}, {114, "2z"}, {115, "2z"}, 
            {116, "3z"}, {117, "3z"}, {118, "3z"}, {119, "3z"}, 
            {120, "4z"}, {121, "4z"}, {122, "4z"}, {123, "4z"}, 
            {124, "5z"}, {125, "5z"}, {126, "5z"}, {127, "5z"}, 
            {128, "6z"}, {129, "6z"}, {130, "6z"}, {131, "6z"}, 
            {132, "7z"}, {133, "7z"}, {134, "7z"}, {135, "7z"}
        };
    }
}
