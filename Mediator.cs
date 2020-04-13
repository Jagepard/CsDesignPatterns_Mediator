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
        public IDictionary<string, Listener> Listeners { get; } = new Dictionary<string, Listener>();
        public IDictionary<string, string> Events { get; } = new Dictionary<string, string>();

        public void AddListener(string name, Listener listeneer, string methodName)
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

            Listener listener = Listeners[name];
            string methodName = Events[name];

            listener.GetType().GetMethod(methodName).Invoke(listener, null);
        }
    }
}
