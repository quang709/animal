namespace animal
{
    internal class Animal
    {
        private string name { get; set; }
        private string sound { get; set; }

      

       public Animal (string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }
        public string GetInfo(string name, string sound)
        {

            return $"{name} say {sound}";
        }
    }
}