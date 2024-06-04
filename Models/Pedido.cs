namespace Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string  Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }
    }
}
