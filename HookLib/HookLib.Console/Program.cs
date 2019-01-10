using System;
using System.Linq;
using HookLib;
using HookLib.Windows;
using System.IO;

namespace TimeSlice.Console
{
    public class Program
    {
        public static StreamWriter log = null;

        static void Main(string[] args)
        {
            // ------------------Create Log File & Open file stream------------------
            

            // Create file stream to write;

            log = new StreamWriter("log.txt");

            var mgr = new HookManager();

            mgr.KeyPressed += GlobalKeyPressed;
            //mgr.KeyDown += GlobalKeyDown;
            //mgr.KeyUp += GlobalKeyUp;
            //mgr.MouseMove += GlobalMouseMove;

            System.Console.WriteLine("Connected.");

            var messagePump = new WindowsMessagePump();
            messagePump.Run();
            
        }

        static void GlobalMouseMove(object sender, GlobalMouseEventHandlerArgs args)
        {
            System.Console.WriteLine(args.Point);
        }

        static void GlobalKeyDown(object sender, GlobalKeyEventHandlerArgs args)
        {
            // ------------------Print keyboard activity into Console------------------

            // ------------------Print keyboard activity into LogFile------------------

            log.WriteLine(args.Time + ":KeyDown:" + args.Character);
            log.Flush();

        }

        static void GlobalKeyUp(object sender, GlobalKeyEventHandlerArgs args)
        {
            // ------------------Print keyboard activity into LogFile------------------

            log.WriteLine(args.Time + ":KeyUp:" + args.Character);
            log.Flush();

            // ------------------Print keyboard activity into LogFile------------------
        }

        static void GlobalKeyPressed(object sender, GlobalKeyEventHandlerArgs args)
        {
            // ------------------Print keyboard activity into LogFile------------------

            log.WriteLine(args.Time + ":KeyPressed:" + args.Character);
            log.Flush();

            // ------------------Print keyboard activity into LogFile------------------

        }
    }
}