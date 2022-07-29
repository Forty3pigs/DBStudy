namespace GeekbrainsDB
{
    static public class Homework1
    {
        static public void Main()
        {
            Buses();
        }
        public static void Buses()
        {
            string text = "busID;busMark;route;driver;conductor;\n";

            int bCount = 10;
            string[] mark = { "ГАЗ", "МАЗ", "ЛиАЗ" };

            Random random = new Random();
            for (int id = 1; id <= bCount; id++)
            {
                string dName = $"Водитель_{id}";
                string cName = $"Кондуктор_{id}";
                int route = random.Next(1, 300);
                string busMark = mark[random.Next(mark.Length)];
                text += $"{id};{busMark};K-{route.ToString("D3")};{dName};{cName};\n";
            }

            Console.WriteLine(text);
            File.WriteAllText("output.csv", text);

        }

    }
}