using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SubCategoryDetailDto:IDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int categoryId { get; set; }
        public int createdById { get; set; }
        public string createdBy { get; set; }
        public DateTime createdTime { get; set; }
        public int lastUpdatedById { get; set; }
        public string lastUpdatedBy { get; set; }
        public DateTime lastUpdatedTime { get; set; }
    }
}
