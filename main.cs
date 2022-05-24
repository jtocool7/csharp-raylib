using Raylib_cs;
using static Raylib_cs.KeyboardKey;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            int display = Raylib.GetCurrentMonitor();
            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetWindowSize(Raylib.GetMonitorWidth(display), Raylib.GetMonitorHeight(display));
            //Raylib.SetWindowPosition(Raylib.GetMonitorWidth(display) - Raylib.GetMonitorWidth(display), 0);
            Raylib.ToggleFullscreen();
            Vector2 pos = new Vector2(10, 10);


            while (!Raylib.WindowShouldClose())
            {

                if (Raylib.IsKeyDown(KEY_UP))
                {
                    pos.Y -= 0.5f;
                }

                if (Raylib.IsKeyDown(KEY_DOWN))
                {
                    pos.Y += 0.5f;
                }

                if (Raylib.IsKeyDown(KEY_RIGHT))
                {
                   pos.X += 0.5f;
                }

                if (Raylib.IsKeyDown(KEY_LEFT))
                {
                    pos.X -= 0.5f;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GREEN);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);
                Raylib.DrawRectangleV(pos, new Vector2(50, 50) , Color.BLACK);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
