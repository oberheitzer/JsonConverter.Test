using JsonConverter.Test.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace JsonConverter.Test
{
    [TestClass]
    public class JsonConverterTests
    {
        private JsonSerializerOptions _options;

        [TestInitialize]
        public void Init()
        {
            _options = new JsonSerializerOptions() 
            {
                IgnoreNullValues = true
            };
            _options.Converters.Add(new NumberStringConverter());
        }

        [TestMethod]
        public void Get_Int_From_Number_Token_Type_Success()
        {
            int number = JsonSerializer.Deserialize<int>("42", _options);
            Assert.AreEqual(42, number);
        }

        [TestMethod]
        public void Get_Int_From_String_Token_Type_Success()
        {
            int number = JsonSerializer.Deserialize<int>(@"""42""", _options);
            Assert.AreEqual(42, number);
        }

        //[TestMethod]
        //public void Get_Nullable_Int_From_String_Token_Type_Success()
        //{
        //    int? number = JsonSerializer.Deserialize<int?>(@"null", _options);
        //    Assert.AreEqual("", number);
        //}

        [TestMethod]
        public void Get_Double_From_Number_Token_Type_Success()
        {
            double fraction = JsonSerializer.Deserialize<double>("0.4", _options);
            Assert.AreEqual(0.4, fraction);
        }

        [TestMethod]
        public void Get_Double_From_String_Token_Type_Success()
        {
            double fraction = JsonSerializer.Deserialize<double>(@"""0,4""", _options);
            Assert.AreEqual(0.4, fraction);
        }

        [TestMethod]
        public void Get_Short_From_Number_Token_Type_Success()
        {
            short shortValue = JsonSerializer.Deserialize<short>("2", _options);
            Assert.AreEqual(2, shortValue);
        }

        [TestMethod]
        public void Get_Short_From_String_Token_Type_Success()
        {
            short shortValue = JsonSerializer.Deserialize<short>(@"""2""", _options);
            Assert.AreEqual(2, shortValue);
        }
    }
}
