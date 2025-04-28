using Exercise47 = Exercises_Library.Exercise47;
namespace ExerciseTests
{
    [TestClass]
    public sealed class Exercise47Test
    {
        [TestMethod]
        public void UserInputShouldEqualHelloWorld()
        {
            Exercise47 exercise47 = new Exercise47();
            string helloWorld = exercise47.Run();
            string expected = "Hello World!";
            Assert.AreEqual(helloWorld, expected);
        }
    }
}
