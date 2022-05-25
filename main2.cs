// second itteration of the app
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
             Vector2 mouse = Raylib.GetMousePosition();
            Color color = Color.BLACK;
            int score = 10;

            while (!Raylib.WindowShouldClose())
            {
                mouse = Raylib.GetMousePosition();

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

                if (mouse.X > pos.X && mouse.X < pos.X + 50 && mouse.Y > pos.Y && mouse.Y < pos.Y + 50)
                {
                    if(Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        color = Color.RED;
                        Raylib.CloseWindow();
                    } else if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_RIGHT_BUTTON))
                    {
                        color = Color.BLUE;
                    } else {
                        color = Color.BLACK;
                    }
                }
                else
                {
                    color = Color.BLACK;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.GREEN);

                Raylib.DrawText("Mouse X:" + mouse.X.ToString(), 12, 12, 20, Color.BLACK);
                Raylib.DrawText("Mouse Y:" + mouse.Y.ToString(), 12, 32, 20, Color.BLACK);
                Raylib.DrawText("Pos X:" + pos.X.ToString(), 12, 52, 20, Color.BLACK);
                Raylib.DrawText("Pos Y:" + pos.Y.ToString(), 12, 72, 20, Color.BLACK);
                Raylib.DrawRectangleV(pos, new Vector2(50, 50) , color);
                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
