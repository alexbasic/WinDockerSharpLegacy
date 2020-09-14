using System;
using System.Net;

namespace WinDockerSharpLegacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application for testing of asseccing to host(local) mashine from the Docker on Windows");
            var endPoint = "http://host.docker.internal/test/ok";

            var client = new WebClient();

            Console.WriteLine($"Access to endpoint: {endPoint}");
            var okString = client.DownloadString(endPoint);

            Console.WriteLine($"Success! Result: {okString}");
        }
    }
}
