using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JsonToCSV.Models
{
    /// <summary>
    /// คำถามสำหรับศาสนสถาน
    /// </summary>
    public class Religious
    {
        /// <summary>
        /// จำนวนพระสงฆ์ สามเณร ชี เด็กวัด ผู้มาประกอบศาสนกิจ
        /// </summary>
        public int? PeopleCount { get; set; }
    }
}