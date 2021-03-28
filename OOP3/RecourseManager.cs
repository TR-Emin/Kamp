using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        //Method injection
        public void DoRecourse(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // Başvuru yap methodu
            // Başvuru bilgilerini değerlendirme

            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void CreditGivePreliminaryInformation(List<ICreditManager> credits)
        {
            // Kredi Ön bilgilendirmesi yap
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }

        }
    }
}
