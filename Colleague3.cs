/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Colleague3 : Listener
    {
        public void OnEvent()
        {
            Console.WriteLine("Colleague3: reacts on notify");
        }
    }
}
