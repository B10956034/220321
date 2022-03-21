using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _220321
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int res = add(3,5);
            //Console.WriteLine(res);

            //Car myCar = new Car();
            //myCar.ShowInfo();

            //Car CarA = new CarA();
            //CarA.opendoor();

            //await MyHttpClientAsync();

            ////抽十次亂數
            //for(int i = 1; i <= 10; i++)
            //{
            //    int num = myRandom(1, 100);
            //    Console.WriteLine(num);
            //}

            //猜數字
            int num = myRandom(1, 100); //68
            for (int i = 1; i <= 5; i++)
            {
                int min = 1, max = 100;
                Console.WriteLine("輸入數字(1~100)");
                int input;
                input = int.Parse(Console.ReadLine());

                if (input == num)
                {
                    Console.WriteLine("答對了");
                }
                //91
                if (input > num)
                {
                    //1-91
                    max = input;
                    Console.WriteLine("答錯了，數字介於" + min + "~" + input);

                }
                //47
                if (input < num)
                {
                    min = input;
                    Console.WriteLine("答錯了，數字介於" + input + "~" + max);

                }
                

            }
        }




        static private async Task MyHttpClientAsync()
        {
            ////string url = "https://www.moeasmea.gov.tw/api/v1/rest/datastore/0800056476";
            //string url = "https://datacenter.taichung.gov.tw/swagger/OpenData/7573a518-0881-4a2e-add2-e8496cbafdec";

            //HttpClient client = new HttpClient();
            //// Call asynchronous network methods in a try/catch block to handle exceptions.
            //try
            //{
            //    HttpResponseMessage response = await client.GetAsync(url);
            //    response.EnsureSuccessStatusCode();
            //    string responseBody = await response.Content.ReadAsStringAsync();
            //    // Above three lines can be replaced with new helper method below
            //    // string responseBody = await client.GetStringAsync(uri);

            //    Console.WriteLine(responseBody);
            //}
            //catch (HttpRequestException e)
            //{
            //    Console.WriteLine("\nException Caught!");
            //    Console.WriteLine("Message :{0} ", e.Message);
            //}

            

        }

        static private int add(int a,int b)
        {
            return a + b;
        }

        //亂數
        static private int myRandom(int minNum,int maxNum)
        {
            Random random = new Random();

            return random.Next(minNum, maxNum + 1);

        }
    }
}
