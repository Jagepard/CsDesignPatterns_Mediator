/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    interface IMediator
    {
        void AddListener(string name, Listener listeneer, string methodName);
        void Notify(string name, IHandler handler);
    }
}
