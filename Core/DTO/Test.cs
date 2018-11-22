using System.Collections.Generic;

namespace Core.DTO
{
    public class Test
    {
        public string Code { get; set; }
        public IEnumerable<Simple> Simple { get; set; }
    }
}