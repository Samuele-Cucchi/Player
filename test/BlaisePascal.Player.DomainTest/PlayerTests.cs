using BlaisePascal.Esempi.Domain;

namespace BlaisePascal.Esempi.DomainTest
{
    public class PlayerTests
    {
        [Fact]
        public void Player_ShouldStartWithCorrectValues()
        {
            Player player = new Player("Mario");

            Assert.Equal("Mario", player.Name);
            Assert.Equal(1, player.Level);
            Assert.Equal(0, player.Experience);
            Assert.Equal(100, player.Health);
            Assert.Equal(100, player.MaxHealth);
            Assert.True(player.IsAlive);
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void AddExperience_ShouldIncreaseExperience()
        {
            Player player = new Player("Mario");

            player.AddExperience(50);

            Assert.Equal(50, player.Experience);
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void AddExperience_ShouldIncreaseLevelAndKeepRemainingExperience()
        {
            Player player = new Player("Mario");

            player.AddExperience(250);

            Assert.Equal(3, player.Level);
            Assert.Equal(50, player.Experience);
        }

        [Fact]
        public void AddExperience_ShouldNotChangeValuesWhenAmountIsInvalid()
        {
            Player player = new Player("Mario");

            player.AddExperience(-10);
            player.AddExperience(0);

            Assert.Equal(1, player.Level);
            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void ResetExperience_ShouldSetExperienceToZero()
        {
            Player player = new Player("Mario");

            player.AddExperience(50);
            player.ResetExperience();

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void TakeDamage_ShouldDecreaseHealth()
        {
            Player player = new Player("Mario");

            player.TakeDamage(30);

            Assert.Equal(70, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldKillPlayerWhenHealthReachesZero()
        {
            Player player = new Player("Mario");

            player.TakeDamage(100);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldNotChangeHealthWhenAmountIsInvalid()
        {
            Player player = new Player("Mario");

            player.TakeDamage(0);
            player.TakeDamage(-10);

            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Heal_ShouldIncreaseHealth()
        {
            Player player = new Player("Mario");

            player.TakeDamage(40);
            player.Heal(20);

            Assert.Equal(80, player.Health);
        }

        [Fact]
        public void Heal_ShouldNotExceedMaxHealth()
        {
            Player player = new Player("Mario");

            player.Heal(50);

            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Heal_ShouldNotHealDeadPlayer()
        {
            Player player = new Player("Mario");

            player.TakeDamage(100);
            player.Heal(50);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void AddGold_ShouldIncreaseGold()
        {
            Player player = new Player("Mario");

            player.AddGold(100);

            Assert.Equal(100, player.Gold);
        }

        [Fact]
        public void AddGold_ShouldNotChangeGoldWhenAmountIsInvalid()
        {
            Player player = new Player("Mario");

            player.AddGold(0);
            player.AddGold(-10);

            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void ResetHealth_ShouldRestoreHealthAndRevivePlayer()
        {
            Player player = new Player("Mario");

            player.TakeDamage(100);
            player.ResetHealth();

            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void TakeDamage_ShouldNotDamageDeadPlayer()
        {
            Player player = new Player("Mario");

            player.TakeDamage(100);
            player.TakeDamage(20);

            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void ResetHealth_ShouldRestoreHealthWhenPlayerIsAlreadyAlive()
        {
            Player player = new Player("Mario");

            player.TakeDamage(50);
            player.ResetHealth();

            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }
    }
}