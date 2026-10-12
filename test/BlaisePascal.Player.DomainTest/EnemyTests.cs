using BlaisePascal.Esempi.Domain;

namespace BlaisePascal.Esempi.DomainTest
{
    public class EnemyTests
    {
        [Fact]
        public void Enemy_ShouldInitializeWithCorrectValues()
        {
            Enemy enemy = new Enemy("Goblin", 80, 20);

            Assert.Equal("Goblin", enemy.Name);
            Assert.Equal(80, enemy.Health);
            Assert.Equal(20, enemy.Damage);
        }

        [Fact]
        public void Enemy_ShouldNotHaveNegativeHealth()
        {
            Enemy enemy = new Enemy("Goblin", -10, 20);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldNotExceedMaxHealth()
        {
            Enemy enemy = new Enemy("Goblin", 150, 20);

            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldBeAliveWhenHealthIsPositive()
        {
            Enemy enemy = new Enemy("Goblin", 50, 20);

            Assert.True(enemy.IsAlive());
        }

        [Fact]
        public void Enemy_ShouldNotBeAliveWhenHealthIsZero()
        {
            Enemy enemy = new Enemy("Goblin", 0, 20);

            Assert.False(enemy.IsAlive());
        }

        [Fact]
        public void Enemy_ShouldDecreaseHealthWhenTakingDamage()
        {
            Enemy enemy = new Enemy("Goblin", 80, 20);

            enemy.TakeDamage(30);

            Assert.Equal(50, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldSetHealthToZeroWhenDamageIsTooHigh()
        {
            Enemy enemy = new Enemy("Goblin", 50, 20);

            enemy.TakeDamage(100);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void Enemy_ShouldNotChangeHealthWhenDamageIsNegative()
        {
            Enemy enemy = new Enemy("Goblin", 80, 20);

            enemy.TakeDamage(-10);

            Assert.Equal(80, enemy.Health);
        }
    }
}