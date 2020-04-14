/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    class Colleague1 : IListener
    {
        public void OnEvent()
        {
            Console.WriteLine("Colleague1: reacts on notify");
        }
    }
}
