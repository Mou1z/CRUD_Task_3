[TestClass]
public class CRUD_Task_3_Tests
{
    [TestMethod]
    public void TestOutputFormat()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);

            CRUD_Task_3.Main(null);

            string output = sw.ToString();


            string[] expectedOutputLines = new string[]
            {
                "5, Milk, Dairy, 2.49, 80",
                "7, Bread, Bakery, 1.99, 90",
                "8, Chicken, Meat, 4.99, 50"
            };

            string[] outputLines = output.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            Assert.AreEqual(expectedOutputLines.Length, outputLines.Length, "Number of output lines does not match.");

            for (int i = 0; i < expectedOutputLines.Length; i++)
            {
                Assert.AreEqual(expectedOutputLines[i], outputLines[i], $"Output line {i + 1} does not match expected format.");
            }
        }
    }
}