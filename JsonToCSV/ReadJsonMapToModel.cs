using JsonToCSV.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace JsonToCSV
{
    public class ReadJsonMapToModel
    {

        private static string _path = @""; // กำหนด path ของ text file
        public List<CommunitySample> Community(List<SurveyData> survey)
        {
            var ComList = survey.Where(it => it.SampleType == "c").ToList();
            var listCom = new List<CommunitySample>();
            foreach (var com in ComList)
            {
                var commu = ReadModelForm<CommunitySample>(com.ContainerName, com.BlobName);
                listCom.Add(commu);
            }
            return listCom;
        }

        public List<BuildingSample> Building(List<SurveyData> survey){
            var BuildingList = survey.Where(it => it.SampleType == "b").ToList();
            var listBuilding = new List<BuildingSample>();
            foreach (var building in BuildingList)
            {
                var bd = ReadModelForm<BuildingSample>(building.ContainerName, building.BlobName);
                listBuilding.Add(bd);
            }
            return listBuilding;
        }

        public List<HouseHoldSample> HouseHold(List<SurveyData> survey){
            var UnitList = survey.Where(it => it.SampleType == "u").ToList();
            var listUnit = new List<HouseHoldSample>();
            foreach (var unit in UnitList)
            {
                var unt = ReadModelForm<HouseHoldSample>(unit.ContainerName, unit.BlobName);
                listUnit.Add(unt);
            }
            return listUnit;
        }

        private static T ReadModelForm<T>(string container, string blobName)
        {
            var path = $@"{_path}\{container}\{blobName}";

            using (var reader = new StreamReader(path))
            {
                var jsonString = reader.ReadToEnd();
                var model = JsonConvert.DeserializeObject<T>(jsonString);
                return model;
            }
        }

    }
}