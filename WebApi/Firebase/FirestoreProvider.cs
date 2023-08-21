using Google.Cloud.Firestore;

namespace WebApi.Firebase
{
    public class FirestoreProvider:IFirestoreProvider
    {
        private FirestoreDb _firestoreDb;


        public FirestoreProvider()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"firebaseConfigurations.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            _firestoreDb = FirestoreDb.Create("loggingwebapi");


        }
        public FirestoreDb db()
        {
            return _firestoreDb;
        }


    }
}
