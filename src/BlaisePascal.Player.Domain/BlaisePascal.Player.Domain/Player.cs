namespace BlaisePascal.Player.Domain
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public bool IsAlive { get; private set; }
        public int Gold { get; private set; }

        public Player(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        public void AddExperience(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Experience = Experience + amount;

            if (Experience >= 100)
            {
                Level = Level + Experience / 100;
                Experience = Experience % 100;
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0 || !IsAlive)
            {
                return;
            }

            Health = Health - amount;

            if (Health <= 0)
            {
                Health = 0;
                IsAlive = false;
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0 || !IsAlive)
            {
                return;
            }

            Health = Health + amount;

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public void AddGold(int amount)
        {
            if (amount <= 0)
            {
                return;
            }

            Gold = Gold + amount;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }
    }
}
