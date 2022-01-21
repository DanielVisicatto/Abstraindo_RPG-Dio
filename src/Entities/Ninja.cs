namespace ProjetoGFT_Abstraindo_Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType; 
            base.HP = HP;
            base.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou a Kunai!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 0 && Bonus <= 4) return this.Name + " Lançou a Bronze Shuriken com Bônus de " + Bonus;
            else if(Bonus >= 5 && Bonus <= 6) return this.Name + " Lançou a Silver Shuriken com Bônus de " + Bonus;
            else return this.Name + " Lançou a Golden Kunai com Bônus de " + Bonus;

        }
    }
}