namespace RSwitch.AMBS.Utility.Exceptions
{
    public class ShowErrorMessage : Exception
    {
        public ShowErrorMessage() : base()
        {
        }
        public ShowErrorMessage(string message) : base(message)
        {

        }
        public ShowErrorMessage(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
