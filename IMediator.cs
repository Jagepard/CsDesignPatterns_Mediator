/*
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Mediator
{
    public interface IMediator
    {
        void AddListener(AbstractListener listener, string methodName);
        void Notify(string name, IHandler handler);
    }
}
