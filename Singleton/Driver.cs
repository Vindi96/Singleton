using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Driver
    {
        private static Driver driver;
        private Driver()
        {

        }

        public static Driver Getter()
        {
            if(driver == null)
            {
                driver = new Driver();
                return driver;
            }
            return driver;


        }
    }
}
