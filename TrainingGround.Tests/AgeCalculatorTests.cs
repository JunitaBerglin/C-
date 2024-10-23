namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private AgeCalculator _calculator;

    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }

    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {

        var age = _calculator.GetAge(1972, 2022);

        Assert.Equal(50, age);
    }
}