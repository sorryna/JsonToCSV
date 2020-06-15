using JsonToCSV.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;

namespace JsonToCSV
{
    public class WriteFile
    {
        public void WriteFileCommu(string fileName, List<CommunitySample> dataLst)
        {
            var pathFolder = $@"ExportData\";
            var pathFile = $@"ExportData\{fileName}.csv";

            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            var dataWrite = dataLst.Select(it => new
            {
                SampleId = it._id
            })
            .ToList();
            using (var writer = new StreamWriter(pathFile))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(dataWrite);
            }
        }

        private static void WriteFileBuilding(string fileName, List<BuildingSample> dataLst)
        {
            var pathFolder = $@"F:\CSV";
            var pathFile = $@"F:\CSV\{fileName}.csv";

            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            var dataWrite = dataLst.Select(it => new
            {
                SampleId = it._id,
                EA = it.EA,
                Road = it.Road,
                Alley = it.Alley,
                Name = it.Name,
                HouseNo = it.HouseNo,
                Latitude = it.Latitude.HasValue ? it.Latitude.Value : 0,
                Longitude = it.Longitude,
                BuildingType = it.BuildingType,
                Other = it.Other,
                AccessCount = it.AccessCount,
                Accesses = it.Accesses,
                VacancyCount = it.VacancyCount,
                AbandonedCount = it.AbandonedCount,
                UnitCountComplete = it.UnitCountComplete,
                UnitCount = it.UnitCount,
                UnitAccess = it.UnitAccess,
                VacantRoomCount = it.VacantRoomCount,
                OccupiedRoomCount = it.OccupiedRoomCount,
                WaterQuantity = it.WaterQuantity,
                FloorCount = it.FloorCount,
                Comments = it.Comments,
                PeopleCount = it.PeopleCount,
                RecCtrl = it.RecCtrl,
                Status = it.Status
            })
            .ToList();

            using (var writer = new StreamWriter(pathFile))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(dataWrite);
            }
        }
    }
}