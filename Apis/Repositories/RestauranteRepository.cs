using Apis.Modelo;

namespace Apis.Repositories
{
    public class RestauranteRepository
    {
        public List<Restaurante>  DevuelveRestaurantes() 
        { 

            List<Restaurante> restaurantes = new List<Restaurante>();

            Restaurante restaurant = new Restaurante
            {
                Id = 1,
                Nombre = "McDonalds",
                CostoComercial = 1000000,
                Direccion = "Orellana",
                PetFriendly = false

            };

            Restaurante restaurante2 = new Restaurante
            {
                Id = 2,
                Nombre = "Burguer King",
                CostoComercial = 50000,
                Direccion = "Orellana",
                PetFriendly = true

            };
            restaurantes.Add(restaurant);
            restaurantes.Add(restaurante2);
            return restaurantes;
        
        
        
        }
    }
}
