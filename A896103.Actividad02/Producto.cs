namespace A896103.Actividad02
{
    public class Producto
    {
        private int nro;
        private int stock;

        public Producto(int nro, int stock)
        {
            this.nro = nro;
            this.stock = stock;
        }

        public int NumerodeProducto 
        {
            get { return this.nro; }
        }
        public int Stock { get { return this.stock; } }

        public void RestarStock()
        {
            this.stock = this.stock - 1;
        }

        public void SumarStock()
        {
            this.stock = this.stock + 1;
        }
    }
}