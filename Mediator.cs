/*
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;
using System.Reflection;

namespace CsDesignPatterns_Mediator
{
    internal class Mediator : IMediator
    {
        private IDictionary<string, AbstractListener> Listeners { get; } = new Dictionary<string, AbstractListener>();
        private IDictionary<string, string> Events { get; } = new Dictionary<string, string>();

        public void AddListener(AbstractListener listener, string methodName)
        {
            if (Listeners.ContainsKey(listener.GetType().Name) && Events.ContainsKey(listener.GetType().Name))
            {
                throw new Exception("Command already exists");
            }

            Listeners.Add(listener.GetType().Name, listener);
            Events.Add(listener.GetType().Name, methodName);
        }

        public void Notify(string name, IHandler handler)
        {
            if (!Listeners.ContainsKey(name) && !Events.ContainsKey(name))
            {
                throw new Exception(name + " does not exist in the Dictionary");
            }

            var listener = Listeners[name];
            var methodName = Events[name];

            if (handler == null)
            {
                listener.GetType().GetMethod(methodName)?.Invoke(obj: listener, parameters: null);
                return;
            }

            listener.GetType().GetMethod(methodName)?.Invoke(obj: listener, parameters: new object[] { handler });
        }
    }
}
