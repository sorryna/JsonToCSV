using MongoDB.Driver;
using JsonToCSV.Models;
using System.Collections.Generic;

namespace JsonToCSV
{
    public class QryDB
    {
        private static IMongoCollection<SurveyData> surveyData { get; set; }
        private static IMongoCollection<EAInfo> EaInfo { get; set; }
        public QryDB()
        {
            // connect to data base
            var connectionString = "mongodb://firstclass:Th35F1rstCla55@mongoquickx4h3q4klpbxtq-vm0.southeastasia.cloudapp.azure.com/wdata";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("wdata");
            surveyData = database.GetCollection<SurveyData>("Survey");
            EaInfo = database.GetCollection<EAInfo>("ea");
        }

        public List<EAInfo> GetEAInfos(string cwt, string amp, string tam)
        {
            return EaInfo.Find(it => it.CWT == cwt && it.AMP == amp && it.TAM == tam).ToList();
        }
        public List<SurveyData> Qry(string EAcode)
        {
            var survey = surveyData.Aggregate()
            // กำหนดเงื่อนไข พื้นที่ที่ต้องการ
            .Match(it => it.EA == EAcode && it.Enlisted == true && it.DeletionDateTime == null)
            .Project(it => new SurveyData
            {
                SampleType = it.SampleType,
                BuildingId = it.BuildingId,
                ContainerName = it.ContainerName,
                BlobName = it.BlobName
            })
            .ToList();
            return survey;
        }
    }
}