using System;
using System.Collections.Generic;

namespace FrameData_API.Models
{
    public partial class Hawkeye
    {
        public int MoveId { get; set; }
        public string MoveName { get; set; }
        public string Input { get; set; }
        public string Damage { get; set; }
        public string Startup { get; set; }
        public string Active { get; set; }
        public string Recovery { get; set; }
        public string Total { get; set; }
        public string BlockAdvantage { get; set; }
        public string HitAdvantage { get; set; }
        public string CounterhitAdvantage { get; set; }
    }
}
