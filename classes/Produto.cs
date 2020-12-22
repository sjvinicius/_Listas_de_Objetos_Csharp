namespace _POO_Listas_de_Objetos.classes
{
    public class Produto
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private float preco;
        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public Produto(){

        }

        public Produto(int _id,string _nome,float _preco) {

            this.Id = _id;
            this.Nome = _nome;
            this.Preco = _preco;

        }
        
        
    }
}