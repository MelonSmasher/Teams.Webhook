namespace Teams.Webhook
{
    public class DateInput : Input
    {
        public bool IncludeTime { get; set; }

        public DateInput() : base("DateInput")
        {

        }
    }
}
