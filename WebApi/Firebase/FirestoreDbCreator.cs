using Google.Cloud.Firestore;

namespace WebApi.Firebase
{
    public class FirestoreDbCreator
    {
        

            public FirestoreDb _firestoreDb;

            public FirestoreDbCreator()
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + @"firebaseConfigurations.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

                _firestoreDb = FirestoreDb.Create("loggingwebapi");
            }
    }
}
