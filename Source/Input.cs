//(C) 2019 Daniel luther
//The Racing Engine Input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL4;
using OpenTK;


namespace RacerEngine
{
    public class Input
    {
        private static List<Key> currentKeys = new List<Key>();
        private static List<Key> downKeys = new List<Key>();
        private static List<Key> upKeys = new List<Key>();


        //Mouse
        public static List<MouseButton> currentMouseButtons = new List<MouseButton>();
        public static List<MouseButton> downMouseButtons = new List<MouseButton>();
        public static List<MouseButton> upMouseButtons = new List<MouseButton>();


        internal static void Start()
        {

        }

        internal static void Update()
        {
            //Keyboard
            downKeys.Clear();
            for(int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if(GetKey((Key)i) && !currentKeys.Contains((Key)i))
                {
                    downKeys.Add((Key)i);
                }
            }

            upKeys.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if (!GetKey((Key)i) && currentKeys.Contains((Key)i))
                {
                    upKeys.Add((Key)i);
                }
            }

            currentKeys.Clear();
            for(int i = 0; i < Enum.GetNames(typeof(Key)).Length; i++)
            {
                if (GetKey((Key)i))
                {
                    currentKeys.Add((Key)i);
                }
            }
            //
            //Mouse
            //
            downMouseButtons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if (GetMouseButton((MouseButton)i) && !currentMouseButtons.Contains((MouseButton)i))
                {
                    downMouseButtons.Add((MouseButton)i);
                }
            }

            upMouseButtons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if (!GetMouseButton((MouseButton)i) && currentMouseButtons.Contains((MouseButton)i))
                {
                    upMouseButtons.Add((MouseButton)i);
                }
            }

            currentMouseButtons.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(MouseButton)).Length; i++)
            {
                if (GetMouseButton((MouseButton)i))
                {
                    currentMouseButtons.Add((MouseButton)i);
                }
            }
        }

        public static bool GetKey(Key key)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return Keyboard.GetState().IsKeyDown((short)key);
        }

        public static bool GetKeyDown(Key key)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return downKeys.Contains(key);
        }

        public static bool GetKeyUp(Key key)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return upKeys.Contains(key);
        }
        //
        //Mouse
        //
        public static bool GetMouseButton(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return Mouse.GetState().IsButtonDown(mouseButton);
        }

        public static bool GetMouseButtonDown(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return downMouseButtons.Contains(mouseButton);
        }

        public static bool GetMouseButtonUp(MouseButton mouseButton)
        {
            if (!Game.Instance.Focused)
            {
                return false;
            }

            return upMouseButtons.Contains(mouseButton);
        }

        public static Vector2 GetMousePosition()
        {
            return new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
        }

        public static void SetMousePosition(Vector2 position)
        {
            Mouse.SetPosition(position.X, position.Y);
        }

        public static void SetMousePosition(float x, float y)
        {
            Mouse.SetPosition(x, y);
        }

        internal static void FocusCallback()
        {

        }

        public static void CursorVisible(bool visibility)
        {
            Game.Instance.CursorVisible = visibility;
        }
    }
}
