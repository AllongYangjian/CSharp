using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static int[] Maps = new int[100];
        static int[] PlayerPos = new int[2];
        static string[] PlayerName = new string[2];
        static void Main(string[] args)
        {
            ShowGameTitle();
            InputPlayerName();
            Console.Clear();
            Console.WriteLine("{0}士兵用玩家A表示", PlayerName[0]);
            Console.WriteLine("{0}士兵用玩家B表示", PlayerName[1]);
            InitMap();
            DrawMap();
            PlayerGames();
            Console.ReadKey();
        }

        static void PlayerGames()
        {
            while(PlayerPos[0]<99 && PlayerPos[1]<99)
            {
                Console.WriteLine("{0}按任意键开始掷骰子");
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// 输入玩家姓名
        /// </summary>
        static void InputPlayerName()
        {
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while(PlayerName[0] == "")
            {
                Console.WriteLine("玩家A姓名不能为空");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while(PlayerName[1] == "" || PlayerName[0] == PlayerName[1])
            {
                if(PlayerName[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空");
                }else if(PlayerName[0] == PlayerName[1])
                {
                    Console.WriteLine("玩家B的姓名和玩家A的姓名相同");
                    Console.WriteLine("请输入玩家B的姓名");
                }
                PlayerName[1] = Console.ReadLine();
            }
             
        }

        static void ShowGameTitle()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****飞行棋项目*****");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************");
        }

        static void InitMap()
        {
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            int[] pause = { 9, 27, 60, 93 };
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };

            for(int x = 0;x<luckyTurn.Length;x++)
            {
                Maps[luckyTurn[x]] = 1;
            }
            for(int x = 0;x<landMine.Length;x++)
            {
                Maps[landMine[x]] = 2;
            }
            for(int x =0;x<pause.Length;x++)
            {
                Maps[pause[x]] = 3;
            }
            for(int x = 0;x<timeTunnel.Length;x++)
            {
                Maps[timeTunnel[x]] = 4;
            }
        }
        /// <summary>
        /// 画地图的方法
        /// </summary>
        static void DrawMap()
        {
            Console.WriteLine("图例：幸运轮盘：○，地雷：☆，暂停：△，时空隧道：卍");
            #region 第一横行
            for(int x = 0;x<30;x++)
            {
                Console.Write(DrawStringMapByIndex(x));
            }
            Console.WriteLine();
            #endregion

            #region 第一竖行 30-35
            for(int x = 30;x<35;x++)
            {
                for(int y = 0;y<29;y++)
                {
                    Console.Write("　");
                }
                Console.Write(DrawStringMapByIndex(x));
                Console.WriteLine();
            }
            #endregion

            #region 第二横行 35-65
            for(int x = 35;x<65;x++)
            {
                Console.Write(DrawStringMapByIndex(x));
            }
            Console.WriteLine();
            #endregion

            #region 第二竖行 66-70;
            for(int x =65;x<70;x++)
            {
                Console.Write(DrawStringMapByIndex(x));
                for (int y = 0;y<29;y++)
                {
                    Console.Write("　");
                }
                Console.WriteLine();
            }
            #endregion

            #region 第三横行 71 -100
            for (int x = 70; x < 100; x++)
            {
                Console.Write(DrawStringMapByIndex(x));
            }
            Console.WriteLine();
            #endregion
        }

        /// <summary>
        /// 根据索引获取对应位置显示的字符串
        /// </summary>
        /// <param name="x">索引</param>
        /// <returns></returns>
        private static string DrawStringMapByIndex(int x)
        {
            string result = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == x)
            {
                result = "<>";
            }
            else if (PlayerPos[0] == x)
            {
                result = "Ａ";
            }
            else if (PlayerPos[1] == x)
            {
                result = "Ｂ";
            }
            else
            {
                switch (Maps[x])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        result = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        result = "○";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        result = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        result = "△";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        result = "卍";
                        break;
                }
            }
            return result;
        }
    }
}
