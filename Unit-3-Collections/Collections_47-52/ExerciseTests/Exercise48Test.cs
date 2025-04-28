using Exercise48 = Exercises_Library.Exercise48;

namespace ExerciseTests;

[TestClass]
public class Exercise48Test
{
    [TestMethod]
    public void UserInputShouldEqualSeven()
    {
        Exercise48 exercise48 = new Exercise48();
        int numberSeven = exercise48.Run();
        int expected = 7;
        Assert.AreEqual(numberSeven, expected);
    }
}