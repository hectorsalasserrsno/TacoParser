using System;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoLong = new TacoParser();
            //Act
            var actual = tacoLong.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]

        public void ShouldParselatitude(string line, double expected) 
        {
        var tacoLat = new TacoParser();

            var actual = tacoLat.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude) ; 
        }

        //TODO: Create a test ShouldParseLatitude

    }
}
