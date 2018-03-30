using System;

public class ButtomPressedEvent
{
    public class ButtonPressedEvent
    {
        #region Singleton

        private static ButtonPressedEvent _evenement;
        private ButtonPressedEvent()
        {

        }

        public static ButtonPressedEvent GetInstance()
        {
            if (_evenement == null)
            {
                _evenement = new ButtonPressedEvent();
            }
            return _evenement;
        }

        #endregion

        public event EventHandler Handler;

        public void OnButtonPressedHandler(EventArgs e)
        {
            if (Handler != null)
            {
                Handler(this, e);
            }
        }

    }
}
