/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHandler handler = new Handler();
            IMediator mediator = new Mediator();

            try
            {
                mediator.AddListener("colleague_1", new Colleague1(), "OnEvent");
                mediator.AddListener("colleague_2", new Colleague2(), "OnEvent");
                mediator.AddListener("colleague_3", new Colleague3(), "OnEvent");

                mediator.Notify("colleague_1", null);
                mediator.Notify("colleague_2", handler);
                mediator.Notify("colleague_3", handler);
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0} \n", e.Message);
            }
        }
    }
}
