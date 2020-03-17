using System;
using CSharp.Classes;

namespace CSharp.Exec
{
    public class MethodExec: IExecutable
    {
        public void Execute()
        {
            // UseRefOut();
            UsePoint();            
        }

        private static void UsePoint()
        {
            /* Method overloading */
            try
            {
                var point = new Point(0, 0);

                point.Move(15, 20);
                point.GetLocation();

                point.Move(new Point(-52, -32));
                point.GetLocation();

                point.Move(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void UseRefOut()
        {
            /* Ref and Out modifiers */
            int a = 3;
            int b = 4;
            OutRefModifiers.DoAWeirdThing(ref a);
            Console.WriteLine(a);
            OutRefModifiers.DoAWeirdThingWithOut(out b);
            Console.WriteLine(b);
        }

    }
}
