using System;
using System.Windows.Forms;

namespace ZJY1
{
    public class User
    {
        private static int id = 0;


        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
    public class People
    {
        private static int x = 1;
        private static int y = 1;


        public static int X
        {
            get { return x; }
            set { x = value; }
        }

        public static int Y
        {
            get { return y; }
            set { y = value; }
        }


    }
    public class Count
    {

        private static int[,] cs = new int[11, 11]
            {
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0}
            };

        public static int[,] Cs
        {
            get { return cs; }
            set { cs = value; }
        }
    }
    public class ClassShuXing
    {

        private static int[,] sx = new int[15, 9]
            {
                {-5,0,0,1,1,0,0,0,0},
                {-10,0,0,5,3,0,0,0,0},
                {-15,0,0,10,5,0,0,0,0},
                {-15,0,0,10,5,0,0,0,0},
                {30,0,0,0,0,0,0,0,0},
                {0,0,10,0,0,0,0,0,0},
                {0,10,0,0,0,0,0,0,0},
                {0,0,0,0,0,1,0,0,0},
                {0,0,0,0,0,0,1,0,0},
                {0,0,0,0,0,0,0,1,0},
                {0,0,0,0,0,0,0,0,1},
                {0,0,0,0,0,-1,0,0,0},
                {0,0,0,0,0,0,-1,0,0},
                {0,0,0,0,0,0,0,-1,0},
                {0,0,0,0,0,0,0,0,-1}
            };


        public static int[,] Sx
        {
            get { return sx; }
            set { sx = value; }
        }
    }
    public class Wall
    {
        private static int wallx = 0;
        private static int wally = 0;

        public static int Wallx
        {
            get { return wallx; }
            set { wallx = value; }
        }

        public static int Wally
        {
            get { return wally; }
            set { wally = value; }
        }
    }
      public class Key
    {
          private static Boolean key = true;

          public static bool Keyb
          {
              get { return key; }
              set { key = value; }
          }
    }

                            
}