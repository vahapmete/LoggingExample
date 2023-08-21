using Google.Cloud.Firestore;
using WebApi.Firebase;
using WebApi.Models;

namespace WebApi.ProductManager
{
    public class ProductService : IProductService
    {
        private  IFirestoreProvider _firestoreProvider;

        public ProductService(IFirestoreProvider firestoreProvider)
        {
            _firestoreProvider = firestoreProvider;
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _firestoreProvider.db().Collection("Products").Document(product.Id).CreateAsync(product);
            DocumentReference documentReference = _firestoreProvider.db().Collection("Products").Document(product.Id.ToString());
            DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();
            Product productResponse = snapshot.ConvertTo<Product>();
            return productResponse;
        }
    }
}
