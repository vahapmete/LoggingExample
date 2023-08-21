using Google.Cloud.Firestore;

namespace WebApi.Models
{

    [FirestoreData]
    public class Product
    {
        [FirestoreProperty]
        public string Id { get; set; }

        [FirestoreProperty]
        public string Name { get; set; }

        public Product()
        {
            Id=Guid.NewGuid().ToString();
        }
    }

}
