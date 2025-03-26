
namespace BattleSystem
{
    public class Unit
    {
        private string unitName;
        private int unitHealCurrent;
        private int maxHeal;
        private int attackPawer;
        private int healPawer;
        private Random random;
        public Unit(string unitName, int attackPawe, int maxHeal ,int healPawer)
        {
            this.unitName = unitName;
            this.attackPawer = attackPawe;
            this.maxHeal = maxHeal;
            this.healPawer = healPawer;
            this.unitHealCurrent = maxHeal;
            random = new Random();
        }


        public void Attack(Unit unitToAttack ) { 
         double rang = random.NextDouble();
            rang = (rang / 2) * 0.75f;
            int attackdamge = (int)(attackPawer * rang);
            unitToAttack.TakeDamage(attackdamge);
            Console.WriteLine($"{unitToAttack.unitName} is attak and damge is {attackdamge}");

        }
        bool IsDead() { return unitHealCurrent <= 0; }
        public void TakeDamage(int damage)
        {
            unitHealCurrent -= damage;
            if (IsDead())
            {
                Console.WriteLine(unitName + " is dead");
            }

        }
        public int GetCurrentHealth() {return unitHealCurrent; }
        public string GetUnitName() {return unitName;}
        public void GetHeal(Unit unitToHeal)
        {
            double rang = random.NextDouble();
            rang = (rang / 2) * 0.75f;
            int healAmount = (int)(healPawer * rang);
            if (unitHealCurrent == maxHeal)
                unitHealCurrent = maxHeal;
            else { unitHealCurrent += healAmount; }
            Console.WriteLine( unitName + " heals " + unitHealCurrent);
        }
    }
}
