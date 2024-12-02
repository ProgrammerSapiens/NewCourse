namespace DesignPatterns.Tuesday.SmartHome
{
    internal class SmartHomeFacade
    {
        private readonly LightingControl _lightingControl;
        private readonly ClimateControl _climateControl;
        private readonly SecurityControl _securityControl;

        public SmartHomeFacade(LightingControl lightingControl, ClimateControl climateControl, SecurityControl securityControl)
        {
            _lightingControl = lightingControl;
            _climateControl = climateControl;
            _securityControl = securityControl;
        }

        public void LeaveHome()
        {
            Console.WriteLine("You left home");
            _lightingControl.LightOff();
            _climateControl.ClimateOff();
            _securityControl.SecurityOn();
        }

        public void ArriveHome()
        {
            Console.WriteLine("You have returned home");
            _lightingControl.LightOn();
            _climateControl.ClimateOn();
            _securityControl.SecurityOff();
        }
    }
}
