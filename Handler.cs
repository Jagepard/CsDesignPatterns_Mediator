/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Mediator
{
    internal class Handler : IHandler
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
