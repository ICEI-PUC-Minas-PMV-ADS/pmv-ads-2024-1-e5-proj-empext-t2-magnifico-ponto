using MagnificoPonto.Context;

namespace MagnificoPonto.Models
{
    public class CarrinhoCompra
    {
        private readonly AppDbContext _context;

        //injeta o contexto no contrutor
        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }
        
        public string CarrinhoCompraId { get; set; }

        public List <CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public static CarrinhoCompra GetCarrinho (IServiceProvider services)
        {
            //define uma sessão
            ISession session = 
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            //atribui o id do carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            //retorna o carrinho com o contexto e o Id atribuído ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho (Amigurumi amigurumi)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault (
                s=> s.Amigurumi.AmigurumiId == amigurumi.AmigurumiId &&
                s.CarrinhoCompraId == CarrinhoCompraId);

            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Amigurumi = amigurumi,
                    Quantidade = 1
                };

                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }

            _context.SaveChanges();
        }
    }
}
