using Google.Cloud.Firestore;

namespace WebApi.Firebase
{
    public interface IFirestoreProvider
    {
        public FirestoreDb db();
    }
}
