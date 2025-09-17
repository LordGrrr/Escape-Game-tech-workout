using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigiCraft 
{
    
    public class Primitives {
        public enum Dir    {neutral = 0, left = 1, right = 4}
        public enum Sens   {neutral = 0, up = 2, down = 8}

        public struct HalfDot {
            public int orientation; // Dir + Sens
            public int iteration_step;
            public int cellId; // id = x + y * 17  //  x = id % 17; y = id / 17
            public LineRenderer renderer;
        }
        public struct Dot {
            public HalfDot A;
            public HalfDot B;
        }

        public struct Cell {
            public int id;
            public List<Dot> list;
            public int[] getMatrixPos { get { int[] res = {this.id%17, this.id/17}; return res;} }
        }
            // Matrix 17x14 :: left_right  8 <-> 0 <-> 8 :: down 0 <-> 8 :: up 0 <-> 5
        public Cell[][] matrix = {  new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17],
                                    new Cell[17] };
    }

    public class Engine {
        public static readonly int[] antiClockwise  = {9, 1, 3, 2, 6, 4, 12, 8};
        public static readonly int[] clockwise  = {12, 4, 6, 2, 3, 1, 9, 8};

        // Injection seed (9x6):  Inject 2 dots from all cells contening 1 dot {if} destination contiens {only} one dot {otherwise]-{something_else}.
        // Impulsion: Impact la construction, la structure.
        // Diffusion: Impact la propagation (2 chemins), l'amplification (addition de contenu).
    }
}
