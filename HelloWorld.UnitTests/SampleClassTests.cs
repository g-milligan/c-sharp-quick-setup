namespace HelloWorld.UnitTests;

public class SampleClassTests
{
    private readonly SampleClass unitUnderTest = new();
    private readonly string defaultName = "World";
    private readonly string greeting = "Hello, {0}!";
    
    [Fact]
    public void SayHello_WhenGivenName_ReturnsGreeting() {
        var givenName = "Donkey";

        var actualResult = unitUnderTest.SayHello(givenName); 

        Assert.Equal(string.Format(greeting, givenName), actualResult);
    }

    [Fact]
    public void SayHello_WhenNameIsNotGiven_ReturnsGreeting() {
        var actualResult = unitUnderTest.SayHello();
        Assert.Equal(string.Format(greeting, defaultName), actualResult);
    }

    [Fact]
    public void SayHello_WhenNameIsNull_ReturnsGreeting() {
        var actualResult = unitUnderTest.SayHello(null);
        Assert.Equal(string.Format(greeting, defaultName), actualResult);
    }

    [Fact]
    public void SayHello_WhenNameIsBlank_ReturnsGreeting() {
        var actualResult = unitUnderTest.SayHello("");
        Assert.Equal(string.Format(greeting, defaultName), actualResult);
    }
}
