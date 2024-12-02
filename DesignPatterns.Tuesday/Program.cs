using DesignPatterns.Tuesday.CoffeeMachine;
using DesignPatterns.Tuesday.SmartHome;

namespace DesignPatterns.Tuesday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First task
            RotaryPhone rotaryPhone = new RotaryPhone();
            INewPhone rotaryPhoneAdapter = new RotaryPhoneAdapter(rotaryPhone);
            rotaryPhoneAdapter.Call("+232356545433");

            //Second task
            LegacyLogger legacyLogger = new LegacyLogger();
            ILogger loggerAdapter = new LoggerAdapter(legacyLogger);
            loggerAdapter.Log("Some message");

            //Third task
            Grinder grinder = new Grinder();
            Brewer brewer = new Brewer();
            MilkSteamer milkSteamer = new MilkSteamer();

            CoffeeMachineFacade coffeeMachineFacade = new CoffeeMachineFacade(grinder, brewer, milkSteamer);
            coffeeMachineFacade.MakeCappuccino();

            //Fouth task
            LightingControl lightingControl = new LightingControl();
            ClimateControl climateControl = new ClimateControl();
            SecurityControl securityControl = new SecurityControl();

            SmartHomeFacade smartHomeFacade = new SmartHomeFacade(lightingControl, climateControl, securityControl);
            smartHomeFacade.ArriveHome();
            smartHomeFacade.LeaveHome();
        }
    }
}
