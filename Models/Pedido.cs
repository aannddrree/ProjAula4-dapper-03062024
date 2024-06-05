namespace Models
{
    public class Pedido
    {
        public readonly static string GETALL = "SELECT p.Id, p.Descricao, p.Mesa, i.Id, i.Descricao from TB_PEDIDO p INNER JOIN TB_ITEM i on p.IdItem = i.Id";
        public int Id { get; set; }
        public string  Descricao { get; set; }
        public int Mesa { get; set; }
        public Item Item { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, Descricao: {Descricao}, Mesa: {Mesa}, Item: {Item.Descricao}";
        }
    }
}
