namespace ProjetoGFT_Abstraindo_Jogo_RPG.src.Entities
{
    public abstract class Hero
    {   
        public string Name;
        public int Level;
        public string HeroType;
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
            this.HP = HP;
            this.MP = MP;
            
        }
        public Hero()
        {}
        
        public override string ToString()
        {
            return $@"Personagem: {this.Name} \nLevel: {this.Level} \nHerói do Tipo:{this.HeroType} \nHP:{this.HP} \n{this.MP}";
        }
        public virtual string Attack()
        {
            return this.Name + " " + "Atacou com a sua espada";
        }

    }
    
}