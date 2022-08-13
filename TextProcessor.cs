using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp__Using_Events_and_delegatrtes__
{
    class TextProcessor
    {
        public delegate void MessageHandler(object sender, MessageArgs e);
        public event MessageHandler SendButtonClick;

        protected virtual void OnSendClick(string text )
        {
            if(SendButtonClick != null)
            {
                MessageArgs e = new MessageArgs();
                e.UserText = text;
                SendButtonClick(this, e);

            }
        }

        public void Initiator(string text )
        {
            OnSendClick(text);
        }


        private TextProcessor()
        { }
        private static TextProcessor obj;

        public static TextProcessor GetObject()
        {
            if (obj == null)
                obj = new TextProcessor();
            return obj;
        }


    }
}
