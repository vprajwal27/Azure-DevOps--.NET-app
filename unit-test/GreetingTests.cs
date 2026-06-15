using HelloPrajwal;

namespace HelloPrajwal.Tests;

public class GreetingTests
{
    [Fact]
    public void Message_ReturnsExpectedGreeting()
    {
        Assert.Equal("Hello world from Prajwal!", Greeting.Message);
    }
}
