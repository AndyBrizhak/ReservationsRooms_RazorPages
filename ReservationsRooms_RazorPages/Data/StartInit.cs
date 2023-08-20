using Reservations.Models;


namespace Reservations.Data
{
    public class StartInit : IStartInit 
    {
        public void Start()
        {
            try
            {
                if (SD.Rooms is not null)
                {
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
