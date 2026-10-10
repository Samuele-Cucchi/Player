namespace BlaisePascal.Esempi.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        private int _health;

        public int Health { get { return _health; } }

        //proprietà
        //public int Health
        //{
        //    get { return _health; }
        //    set 
        //    { 
        //        if(value < 0) // caso limite 1
        //        {
        //            _health = 0;
        //        }else if (value > 100) // caso limite 2
        //        {
        //            _health = 100;
        //        }
        //        else // caso normale
        //        {
        //            _health = value;
        //        }
        //
        //    }        
        //}        

        //costruttore
        public Enemy() { }

        public void setHealth(int newHealth)
        {
            if (newHealth < 0) // caso limite 1
                _health = 0;
            else if (newHealth > 100) // caso limite 2
                _health = 100;
            else // caso normale
                _health = newHealth;
        }

        public bool isAlive()
        {
            return _health > 0;
        }

        public void TakeDamage(int damage)
        {
            setHealth(_health - damage);
        }
    }
}