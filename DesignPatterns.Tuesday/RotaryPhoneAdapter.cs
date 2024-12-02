namespace DesignPatterns.Tuesday
{
    internal class RotaryPhoneAdapter : INewPhone
    {
        private readonly RotaryPhone RotaryPhone;

        public RotaryPhoneAdapter(RotaryPhone rotaryPhone)
        {
            RotaryPhone = rotaryPhone;
        }

        public void Call(string number)
        {
            RotaryPhone.DialNumber(number);
        }
    }
}
