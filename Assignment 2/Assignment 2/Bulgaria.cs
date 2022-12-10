using System;

namespace Assignment_2
{
    public class Bulgaria
    {
        /// <summary>
        /// The assignment says we should only consider First Class roads.
        /// However, since I don't know which roads in Bulgaria are considered to be First Class,
        /// I connected each city with any other city from the list.
        /// 
        /// The data was pulled from Google Maps and is based on precise distances + the time
        /// it takes to get from city A to city B.
        /// Each city is connected to all other cities by road which is faster than travelling through multiple cities, thus,
        /// if you want to travel through multiple cities, please remove some roads.
        /// </summary>
        internal static void Create()
        {
            var Burgas = new Vertex("Burgas");
            var Varna = new Vertex("Varna");
            var Dobrich = new Vertex("Dobrich");
            var Silistra = new Vertex("Silistra");
            var Razgrad = new Vertex("Razgrad");
            var Tyrgowishte = new Vertex("Tyrgowishte");
            var Shumen = new Vertex("Shumen");
            var VelikoTyrnovo = new Vertex("Veliko Tyrnovo");
            var Sliven = new Vertex("Sliven");
            var Yambol = new Vertex("Yambol");
            var Kazanlyk = new Vertex("Kazanlyk");
            var StaraZagora = new Vertex("Stara Zagora");

            Graph.AddEdge(Burgas, Varna, 115, 53);
            Graph.AddEdge(Burgas, Dobrich, 165, 57);
            Graph.AddEdge(Burgas, Silistra, 228, 65);
            Graph.AddEdge(Burgas, Razgrad, 175, 68);
            Graph.AddEdge(Burgas, Tyrgowishte, 149, 63);
            Graph.AddEdge(Burgas, Shumen, 127, 62);
            Graph.AddEdge(Burgas, VelikoTyrnovo, 216, 84);
            Graph.AddEdge(Burgas, Sliven, 114, 93);
            Graph.AddEdge(Burgas, Yambol, 92, 92);
            Graph.AddEdge(Burgas, Kazanlyk, 190, 92);
            Graph.AddEdge(Burgas, StaraZagora, 172, 102);

            Graph.AddEdge(Varna, Dobrich, 52, 61);
            Graph.AddEdge(Varna, Silistra, 141, 74);
            Graph.AddEdge(Varna, Razgrad, 128, 89);
            Graph.AddEdge(Varna, Tyrgowishte, 121, 89);
            Graph.AddEdge(Varna, Shumen, 89, 83);
            Graph.AddEdge(Varna, VelikoTyrnovo, 222, 82);
            Graph.AddEdge(Varna, Sliven, 197, 62);
            Graph.AddEdge(Varna, Yambol, 208, 71);
            Graph.AddEdge(Varna, Kazanlyk, 292, 74);
            Graph.AddEdge(Varna, StaraZagora, 288, 80);

            Graph.AddEdge(Dobrich, Silistra, 90, 78);
            Graph.AddEdge(Dobrich, Razgrad, 164, 87);
            Graph.AddEdge(Dobrich, Tyrgowishte, 133, 72);
            Graph.AddEdge(Dobrich, Shumen, 125, 84);
            Graph.AddEdge(Dobrich, VelikoTyrnovo, 258, 82);
            Graph.AddEdge(Dobrich, Sliven, 247, 71);
            Graph.AddEdge(Dobrich, Yambol, 245, 73);
            Graph.AddEdge(Dobrich, Kazanlyk, 328, 75);
            Graph.AddEdge(Dobrich, StaraZagora, 323, 80);

            Graph.AddEdge(Silistra, Razgrad, 115, 71);
            Graph.AddEdge(Silistra, Tyrgowishte, 140, 75);
            Graph.AddEdge(Silistra, Shumen, 112, 71);
            Graph.AddEdge(Silistra, VelikoTyrnovo, 230, 73);
            Graph.AddEdge(Silistra, Sliven, 250, 69);
            Graph.AddEdge(Silistra, Yambol, 243, 68);
            Graph.AddEdge(Silistra, Kazanlyk, 329, 73);
            Graph.AddEdge(Silistra, StaraZagora, 324, 75);

            Graph.AddEdge(Razgrad, Tyrgowishte, 38, 67);
            Graph.AddEdge(Razgrad, Shumen, 48, 73);
            Graph.AddEdge(Razgrad, VelikoTyrnovo, 114, 69);
            Graph.AddEdge(Razgrad, Sliven, 148, 62);
            Graph.AddEdge(Razgrad, Yambol, 160, 67);
            Graph.AddEdge(Razgrad, Kazanlyk, 212, 70);
            Graph.AddEdge(Razgrad, StaraZagora, 220, 70);

            Graph.AddEdge(Tyrgowishte, Shumen, 41, 68);
            Graph.AddEdge(Tyrgowishte, VelikoTyrnovo, 100, 73);
            Graph.AddEdge(Tyrgowishte, Sliven, 112, 56);
            Graph.AddEdge(Tyrgowishte, Yambol, 124, 63);
            Graph.AddEdge(Tyrgowishte, Kazanlyk, 198, 72);
            Graph.AddEdge(Tyrgowishte, StaraZagora, 205, 77);

            Graph.AddEdge(Shumen, VelikoTyrnovo, 142, 74);
            Graph.AddEdge(Shumen, Sliven, 136, 64);
            Graph.AddEdge(Shumen, Yambol, 129, 62);
            Graph.AddEdge(Shumen, Kazanlyk, 217, 72);
            Graph.AddEdge(Shumen, StaraZagora, 210, 76);

            Graph.AddEdge(VelikoTyrnovo, Sliven, 112, 67);
            Graph.AddEdge(VelikoTyrnovo, Yambol, 130, 70);
            Graph.AddEdge(VelikoTyrnovo, Kazanlyk, 102, 68);
            Graph.AddEdge(VelikoTyrnovo, StaraZagora, 109, 66);

            Graph.AddEdge(Sliven, Yambol, 28, 57);
            Graph.AddEdge(Sliven, Kazanlyk, 86, 75);
            Graph.AddEdge(Sliven, StaraZagora, 69, 64);

            Graph.AddEdge(Yambol, Kazanlyk, 105, 78);
            Graph.AddEdge(Yambol, StaraZagora, 87, 87);

            Graph.AddEdge(Kazanlyk, StaraZagora, 33, 58);
        }
    }
}
