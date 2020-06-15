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

            var dataWrite = dataLst.Select(it => new ForExport
            {
                _id = it._id,
                Status = it.Status
            })
            .ToList();
            using (var writer = new StreamWriter(pathFile))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(dataWrite);
            }
        }

        public void WriteFileBuilding(string fileName, List<BuildingSample> dataLst)
        {
            var pathFolder = $@"F:\CSV";
            var pathFile = $@"F:\CSV\{fileName}.csv";

            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            var dataWrite = dataLst.Select(it => new ForExport
            {
                _id = it._id,
                Status = it.Status
            })
            .ToList();

            using (var writer = new StreamWriter(pathFile))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(dataWrite);
            }
        }

        public void WriteFileUnit(string fileName, List<HouseHoldSample> dataLst)
        {
            var pathFolder = $@"F:\CSV";
            var pathFile = $@"F:\CSV\{fileName}.csv";

            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            var dataWrite = dataLst.Select(it => new ForExport
            {
                _id = it._id,
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