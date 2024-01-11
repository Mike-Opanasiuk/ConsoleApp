namespace UnitTestProject
{
    public class UnitTest1
    {
        private const string Expected = "Hello, World!";
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.Equal(Expected, result);
            }
        }
    }
}
