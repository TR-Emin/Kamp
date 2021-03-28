using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();            
            ICreditManager vehicleCreditManager = new VehicleCreditManager();            
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager tradesmanCreditManager = new TradesmanCreditManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {fileLoggerService, databaseLoggerService, smsLoggerService };

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(tradesmanCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager, vehicleCreditManager};
            //recourseManager.CreditGivePreliminaryInformation(credits);

      





        }
    }
}
