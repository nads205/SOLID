namespace Solid_Princicles_Class_Library
{

    public class ServiceStation
    {
        IGateUtility _gateUtility;

        public ServiceStation(IGateUtility gateUtility)
        {
            _gateUtility = gateUtility;
        }
        public void OpenForService()
        {
            _gateUtility.OpenGate();
        }

        public void DoService()
        {
            //Check if service station is opened and then
            //complete the vehicle service
        }

        public void CloseForDay()
        {
            _gateUtility.CloseGate();
        }
    }

    public class ServiceStationUtility : IGateUtility
    {
        public void OpenGate()
        {
            //Open the shop if the time is later than 9 AM
        }

        public void CloseGate()
        {
            //Close the shop if the time has crossed 6PM
        }
    }

    public interface IGateUtility
    {
        void OpenGate();
        void CloseGate();
    }

}
