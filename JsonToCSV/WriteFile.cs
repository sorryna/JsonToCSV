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
            var pathFolder = $@"F:\CSV"; // folder ที่ต้องการ export file
            var pathFile = $@"F:\CSV\{fileName}.csv"; // fileName path

            if (!Directory.Exists(pathFolder)) // check ว่ามี folder ไหม
            {
                Directory.CreateDirectory(pathFolder); //  ถ้าไม่มีจะสร้าง folder ให้
            }
            // model ForExport สามารถเข้าไปสร้าง ตัวแปรที่อยากได้ในการเขียนไฟล์
            var dataWrite = dataLst.Select(it => new ForExport 
            {
                // กำหนดตัวค่าให้ตัวแปลที่เพิ่มใน model Export
                _id = it._id,
                Status = it.Status
            })
            .ToList();
            using (var writer = new StreamWriter(pathFile))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(dataWrite); // เขียนไฟล์
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