/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Colleague2 : Listener
    {
        public void OnEvent()
        {
            Console.WriteLine("Colleague2: reacts on notify");
        }
    }
}
