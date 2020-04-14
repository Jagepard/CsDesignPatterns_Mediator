/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;
using System.Reflection;

namespace CsDesignPatterns_Mediator
{
    class Mediator : IMediator
    {
        public IDictionary<string, IListener> Listeners { get; } = new Dictionary<string, IListener>();
        public IDictionary<string, string> Events { get; } = new Dictionary<string, string>();

        public void AddListener(string name, IListener listeneer, string methodName)
        {
            if (Listeners.ContainsKey(name) && Events.ContainsKey(name))
            {
                throw new Exception("Command already exists");
            }

            Listeners.Add(name, listeneer);
            Events.Add(name, methodName);
        }

        public void Notify(string name, IHandler handler)
        {
            if (!Listeners.ContainsKey(name) && !Events.ContainsKey(name))
            {
                throw new Exception(name + " does not exist in the Dictionary");
            }

            IListener listener = Listeners[name];
            string methodName = Events[name];

            if (handler == null)
            {
                listener.GetType().GetMethod(methodName).Invoke(obj: listener, parameters: null);
                return;
            }

            listener.GetType().GetMethod(methodName).Invoke(obj: listener, parameters: new object[] { handler });
        }
    }
}
