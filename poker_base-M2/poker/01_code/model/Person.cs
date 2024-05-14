
namespace poker.code.model
{
    public class Person
    {
        // Campos privados
        private string name; // Declaração da string chamando 'name'
        private int age;

        // Construtor
        public Person(string name, int age) // Declaração de uma string 'name' e um inteiro 'age'
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
