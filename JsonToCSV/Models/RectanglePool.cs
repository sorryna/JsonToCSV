using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonToCSV.Models
{
    /// <summary>
    /// สระน้ำ สี่เหลี่ยม
    /// </summary>
    public class RectanglePool
    {
        /// <summary>
        /// ความกว้าง
        /// </summary>
        /// <value></value>
        public double? Width { get; set; }

        /// <summary>
        /// ความยาว
        /// </summary>
        /// <value></value>
        public double? Length { get; set; }
    }
}