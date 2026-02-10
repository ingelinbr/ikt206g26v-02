using UtilityLibraries;
using Xunit;

namespace MyLibrary.Tests;

public class StringLibraryXunitTests
{
    [Fact]
    public void StartsWithUpper_Uppercase_ReturnsTrue()
        => Assert.True("Hello".StartsWithUpper());

    [Fact]
    public void StartsWithUpper_Lowercase_ReturnsFalse()
        => Assert.False("hello".StartsWithUpper());

    [Fact]
    public void StartsWithUpper_NullOrEmpty_ReturnsFalse()
    {
        string? s = null;
        Assert.False(s.StartsWithUpper());
        Assert.False(string.Empty.StartsWithUpper());
        Assert.False("   ".StartsWithUpper());
    }
}