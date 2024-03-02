namespace CQRS.Example.Manual_CQRS.Commands.Requests
{
    public class CreateProductCommendRequest
	{
		public string Name { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}
}

