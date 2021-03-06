using System;
using System.Collections.Generic;

namespace Electric.Models
{
    public class Enclosure_DeviceDto
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime Date { set; get; }
        public int ProjectId { set; get; }
        public List<DeviceWithPosition> DeviceWithPosition { set; get; }
        public float TotalPrice { set; get; }
        public EnclosureSpecs EnclosureSpecs { set; get; }
    }
}