using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBS_Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "reedemRewards" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select reedemRewards.svc or reedemRewards.svc.cs at the Solution Explorer and start debugging.
    public class reedemRewards : IreedemRewards
    {

        /*public string getRewards(string custID)
        {
            return "Service is up and running now";
            throw new NotImplementedException();
        }*/
        List<String> rewardsArray = new List<String>();
        public List<string> getRewards(String custID)
        {
            try
            {

                using (rewardsdbEntities1 dataCollector = new rewardsdbEntities1())
                {
                    dataCollector.Database.Connection.Open();
                    foreach (var dataRow in dataCollector.rewardsmasters)
                    {
                        rewardsArray.Add(dataRow.rewardDescription);
                        rewardsArray.Add(dataRow.rewardName);
                    }
                }
            } catch (Exception e)
            {
                throw new Exception("Exception occurred:", e);

            }
            return rewardsArray;
        }
    }
}

