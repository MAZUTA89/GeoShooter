using GameSO;

namespace Enemies
{
    public class EnemyHealth
    {
        int _maxHealth;
        int _currentHelth;
        public bool IsDead
        {
            get
            {
                return _currentHelth == 0;
            }
        }
        public int Helth
        {
            get
            {
                return _currentHelth;
            }
            set
            {
                _currentHelth = value;
                if (_currentHelth < 1)
                    _currentHelth = 0;
                if(_currentHelth > _maxHealth)
                    _currentHelth = _maxHealth;
            }
        }

        public EnemyHealth(EnemySO enemySO)
        {
            Helth = enemySO.Health;
            _maxHealth = Helth;
        }
    }
}
