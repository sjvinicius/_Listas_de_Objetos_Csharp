namespace _POO_Listas_de_Objetos
{
    public class Cartao
    {
        private string bandeira;
        public string Bandeira
        {
            get { return bandeira; }
            set { bandeira = value; }
        }
        
        private string cvv;
        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }
        private string titular;
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        private string vencimento;
        public string Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }
        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int ide;
        public int Ide
        {
            get { return ide; }
            set { ide = value; }
        }
        

        public Cartao(){

        }

        public Cartao( string _bandeira, string _titular, string _numero, string _cvv, string _vencimento) {

            this.Bandeira = _bandeira;
            this.Titular = _titular;
            this.Numero = _numero;
            this.Cvv = _cvv;
            this.Vencimento = _vencimento;

        }

    }
}