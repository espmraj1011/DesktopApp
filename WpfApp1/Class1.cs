using System;

public class Class1
{
    public Class1()
    {
    }
        
     private const string URL = "http://localhost:8080/RESTfulExample/rest/hello/login/";


        static void Main(string[] args)
        {
            if (UserName.Text == "muthuraj" && password.Password == "abcd1234")
            {
                success.Content = "Login Succeed";
            }
            else
            {
                success.Content = "Login Failed";
            }

            Console.WriteLine(UserName.Text);


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL + UserName.Text + "/" + password.Password);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync("").Result;  // Blocking call!
            StreamContent receiveStream = response.Content;

            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Console.WriteLine(readStream.ReadToEnd());
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync.ToString();


                Console.WriteLine(dataObjects);

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
}

