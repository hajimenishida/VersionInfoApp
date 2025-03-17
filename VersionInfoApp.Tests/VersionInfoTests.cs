using System;
using Xunit;

public class VersionInfoTests
{
    [Fact]
    public void Version_Should_Not_Be_Null()
    {
        var version = typeof(Program).Assembly.GetName().Version;
        Assert.NotNull(version);
    }
}
