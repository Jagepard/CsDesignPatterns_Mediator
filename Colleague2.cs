/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Colleague2 : IListener
    {
        public void OnEvent(Handler handler)
        {
            handler.Message = "Colleague2";
            Console.WriteLine("{0}: reacts on notify", handler.Message);
        }
    }
}
