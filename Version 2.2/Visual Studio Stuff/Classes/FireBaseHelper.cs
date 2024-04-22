using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace CypherWithGuna.Classes
{
    internal class FireBaseHelper
    {
        static string fireconfig =
            @"{
  ""type"": ""service_account"",
  ""project_id"": ""safekeyp-37a18"",
  ""private_key_id"": ""6356d4ab0543f984de9f961a9b4fd5a6646c7838"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDWmsgXhwWeXK4Q\nqAd8abctVblunPAXhbMkN327a190nRbuDl5gpzQmaGIdiYqopdCOu4Xz+XJ8KfIf\nCIfZjcLQ8V6GcM5BglDF7rbu/8vwsIaMwTpmfASxLlXiZoZHW05kYwKQgQTJtCQc\nH2YXJzI5WQ+s0HDZWcHcbYe/Nx+aXAhdWvZ1YFjAyvvVg3OJ9plF5lEHOQb7I8Qt\nRjeULtOo2FPhi8xJHYO8CQY2OKCgN3jWJgCc8RJw0//s43Kjqk+r9HGo+0iki99z\nk/xV6z6Qg4IHLHTa69cOgj462p6JUyUC3nxI4+Ii9M2V+tQN7/J01xt6/1xqCN3o\nYV7IJOzpAgMBAAECgf8PdT+sxBdHWyg417ioFI7qBvsMtPmMFF0GNJKmuim1ZZtV\ns2FWYb8YOFgglVcLXi3vTUC1AELOM+VbihjOVXH6pSrDehT64HJhpoiRAH+6ZfJ+\nWfwimODH4m/SZB+FarIcIp81oHvgw9uYkWK+7AmdnP/gNWDhUU4gX1z3K5rn8/2o\n83XgszgZa1qAsWpFCHtsS1bKIk6g9AmtkDq61aK8xo7w9LXjEoLP07GgEXIQyfa9\nqXxPo4k4HmTX285q9PrCBBrhDMDmatHTyL8f8dpDXHzJP1WTVPqucsXXj4HnEDio\n6UTBOqoEohC0wiflP/3TXEjaXnj/4dkdbVnum5UCgYEA/WPfMRpBfC/ZQRBcniPx\nZPoCMgdZQxK+QlkV07kB2aUqSqyZW+7zGZ4FIDDvFxFQmzMd7usaU3gMwUG/jZ0J\nF+Vl4j79aUvGJ94vHexUOmztQ9Z7kwADchbXq8IkxGx9gT2j5od7rbVpPEThKwxC\nrUgqquG3fxGdK1blSArO3qMCgYEA2NCkTZBsXxLoqqMvv7Q0hSXm3od3sG8N9FhW\nU5GKv4p210Wvo2afDv0Aw/onPC3MW46uS9H8aKXU8gImigEH/PvtwbzON8g9q020\npEIBZTW4P3nJT31ANQZG+Q+R5x5ZwAwilw910yWrurMP6lcdWKvzp/Fi/xm9xyd8\nR55AewMCgYEAlECCrW/3MHmuWur/xWayLao47pxuFVg6CQemRaHQ+04vWFFzyN4d\nTbeuuA7pVE3FI4jc0pSranqqu8eEE471aw3EdoL0MU8sONc+KfvDrAtfJnmvA2rW\nmUHUHaIRcPso0x0FcDOEoTWqxKBoPY+G02uNyz0U5zufAWRt8aChOJECgYBqfzll\nO/5vSLtuLY/jqyFtEWvwfDwHNtV04vssOz4azWmIXhtiuKKCWzXIDZS+E4TgqBnm\n9jL0OBh78yB5Av6ofhqP4iys67eW8Ck90Yob66If07NVTyF9qiKsbcBt9NOC6LMI\n3jgyybsrjo7PvZCVoIijQocs5Lj6HOQHzazAfwKBgQD2S7o5UMufOSjM8UuRSNHs\nr9HeudvwY6A53Roh4bpfyXY0NS1crce7WMvj/wZ5tpViw1D2n1gmMk3j+Joqg8Na\nQd9rxVCcv1FWN58WdNhfc9Si6B2jaE7816enucmGDHtzZL1TM10W9UZA8ByDaQWo\n7H5qFkO/8ZOYIYi8qQTVcw==\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-k3jsk@safekeyp-37a18.iam.gserviceaccount.com"",
  ""client_id"": ""108317532972214358886"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-k3jsk%40safekeyp-37a18.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}";

        static string filepath = "";
        public static FirestoreDb db { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            db = FirestoreDb.Create("safekeyp-37a18");

        }
    }
}
