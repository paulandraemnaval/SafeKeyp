using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace Cypher.Classes
{
    internal static class FirebaseHelper
    {
        static string fireconfig = @"{
        ""type"": ""service_account"",
        ""project_id"": ""cypher-b2020"",
        ""private_key_id"": ""2e9d8bddeb718f7d12eb5f0ac4582447732e0d7a"",
        ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCuevjAqwwLQNw5\n3de8tz4HX+BqiAXjhpOmPkR3zL9Pgc0PD5AQQ30RO9M7yB/On2UwAd4wM4Ml12WR\n+TYqXk7s2B7e5C9mXGQUhRlJChOjwMilQvI2Y05aDnfKkX7czGUI5TZJLpsjRfNA\n6L8SKZ4f/Zvwf7wE1cW4onQOdDr2mG5ygYA9IYeUS7UCTiA7JEDG642Q0DIvp0DB\nh+FCcZvmjnMy2baY/om/+wEi7OqN2kZx3Xp3u6YV3i9C1wxgClx6mTDiLUNmMtHT\nbrh0MrY3L18i9OmWytmjQyAIuBfmbmkj6qIRtY6RF5qcCU+LB7KT+odFOFWu2nH5\nXebucSpNAgMBAAECggEAQGd18LBylqjPYbDIlIlTJSe3z7r76XtgfunXHh1+tJtm\nFNwawlYXEUhy9Usuqnddw3W9DS/Ghi5W+KXz33nGSliQNJgoAvGxo31p0vMcQsLD\njXUDsR3A6y8R+rzwBhKQbNMm0aaZb1C/tML03IBuNMLJT+HmhiZegIO+sSMoLKOE\nm9mIwvy38MkxbcDZgXW7vOvvb1Jaw9T7izpbsqyO09f0+jRuP9RByF2S3NT8BpNM\nh507G0siNQWoNlvoOoJmNY+CJqFNx8gN8OyCj8EUZC4V/PsbNnu2u44ME+z4Dto7\njtonNoUhy0KU31MiZnK2VpvQlJlIwRBPqO9LRVQeBQKBgQDrUcrJK3EvtvvMDY7U\niEREM18Y+jRiCGSXYnLk+/2UbTc22eP77xElTprFhQo45RlYxdrO5uEnis3f+hWZ\njzBagx5eZj36AML82JNji0s5mIVnB5rJcZziIos1dp2gIDWgzkcT4UP8yGa92Mlg\nqfzQAU05L/9bV31HGvDeFn4OewKBgQC90GxVz5X2QdrFRcjhcprvHn/pVMcH6QnM\nUrDjCSV7IBSBNK3OWCl2YlWgeUhO4yTmUWqoASxNSnWUzNV8RaoiuvufzaXG1D9V\n5UDSoxXF27AYOU9Zv/WPYRb+LibUDh2qfbpvGfkzjb4e6iEsQEiKaD1fWV1IVImo\ns79VAmmz1wKBgQCxifsp/ameqzqcABqjxM9keTGlYZhF4jkqce9nTatK4X+H1aqJ\nOBxCfmSM40wMEuUlsdjcwxpaQAIFmuPTAFIl58jwxci6pvp101yX/M7bfHQhgH5K\nv3nyrsdCpeRUnBh540eC+zDVNck2MKn2USnZMTI3FDxfiMmO7QePN38RowKBgHGV\ndA6Rbspys+gSj1ehTedDGAXXTlaEc/GJlgH16jDYjIyYqlzs0rrdsyGZEdTrBZyx\nIaKxOQJzSRMm06VOxrWLsKD63XWycsgCrJyfLJs+kAye1sX9IYOP9MNbeK6yV7w7\nCkILh9z6t8cmEX26Ze403GzfO/vZYprKHPdQv1H3AoGBANnteqiR+UcIsP05OhgW\nA385LLsmC/QfJxYCa586m17FFWHJ633WMVL4ehuamQinyF92VEc+kzHj3v04ldPB\nJDjEhC0lNnEesRTJjUnYsfVt20wGNlxIrQL032jrJV85mKaEs51cKzJsJrDApuaz\n1W9Q5M3Por7GFIxJgIO2mLx9\n-----END PRIVATE KEY-----\n"",
        ""client_email"": ""firebase-adminsdk-lky0k@cypher-b2020.iam.gserviceaccount.com"",
        ""client_id"": ""108263329430239203981"",
        ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
        ""token_uri"": ""https://oauth2.googleapis.com/token"",
        ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
        ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-lky0k%40cypher-b2020.iam.gserviceaccount.com"",
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
            db = FirestoreDb.Create("cypher-b2020");

        }
    }
}
