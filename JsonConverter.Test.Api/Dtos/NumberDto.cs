using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonConverter.Test.Api.Dtos
{
    public class NumberDto
    {
        public int IntProperty { get; set; }
        public int? NullableIntProperty { get; set; }
        public double DoubleProperty { get; set; }
        public double? NullableDoubleProperty { get; set; }
        public short ShortProperty { get; set; }
        public short? NullableShortProperty { get; set; }
    }
}
