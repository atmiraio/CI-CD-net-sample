using NUnit.Framework;

namespace WebApi.DevOps.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewEnviromentTest()
        {
            var enviroment = new Enviroment(1, "Testing", "TEST");
            Assert.NotNull(enviroment);
        }
    }
}