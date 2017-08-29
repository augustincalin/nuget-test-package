using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace MyNugetPackage {
    public class MyUsefulClass {
        public string GetMessage(string name) => $"Hello, {name}!";
        public async Task<string> GetGoogle() {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://www.google.com");
        }
    }


}
