using BlaisePascal.Esempi.Domain; 

namespace BlaisePascal.Esempi.DomainTest
{
    public class PlayerTests
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne()
        {
            Player player = new Player("Mario");

            Assert.Equal(1, player.Level);
        }
    }
}
