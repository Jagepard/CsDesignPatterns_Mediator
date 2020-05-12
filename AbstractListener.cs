using System;

namespace CsDesignPatterns_Mediator
{
    public abstract class AbstractListener
    {
        public void OnEvent(IHandler handler){
            handler.Message = this.GetType().Name + ": Fine, thanks!";
            Console.WriteLine("{0}\n", handler.Message);
        }
        
        public void ToGreet(string listenerName, IMediator mediator, IHandler handler)
        {
            Console.WriteLine("{0} How are you {1}?", this.GetType().Name, listenerName);
            mediator.Notify(listenerName, handler);
        }
    }
}