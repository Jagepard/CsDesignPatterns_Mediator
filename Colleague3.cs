/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Colleague3 : Listener
    {
        public void OnEvent(Handler handler)
        {
            handler.Message = "Colleague3";
            Console.WriteLine("{0}: reacts on notify", handler.Message);
        }
    }
}
