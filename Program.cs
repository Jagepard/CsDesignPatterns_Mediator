/*
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IHandler handler = new Handler();
            IMediator mediator = new Mediator();
            AbstractListener listener1 = new Colleague1();
            AbstractListener listener2 = new Colleague2();
            AbstractListener listener3 = new Colleague3();

            try
            {
                mediator.AddListener(listener1, "OnEvent");
                mediator.AddListener(listener2, "OnEvent");
                mediator.AddListener(listener3, "OnEvent");
                
                listener1.ToGreet(listener2.GetType().Name, mediator, handler);
                listener2.ToGreet(listener3.GetType().Name, mediator, handler);
                listener3.ToGreet(listener1.GetType().Name, mediator, handler);
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0} \n", e.Message);
            }
        }
    }
}
