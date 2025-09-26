using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Switches.Tests;

[Collection("Collection")]
public sealed class SwitchTests : FixturedUnitTest
{
    public SwitchTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
