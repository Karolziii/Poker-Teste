//m4rc3lo - 2024-04-23
namespace poker.code.model
{// comentar toda a classe
    public class Person
    {
        // Campos privados
        private string name;
        private int age;

        // Construtor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Propriedade pública para acessar e modificar o nome
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Propriedade pública para acessar e modificar a idade
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}