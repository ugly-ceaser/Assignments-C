using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtlantisScientific;
using GarciaInfoSystem;

namespace DataAndVariables

{
    class Program
    {
        static void Main(string[] args)
        {

           // AtlantisScientific.getData.getInput();
          //  GarciaInfoSystem.getData.studData();
            









          
           





















        }
    }
}



namespace AtlantisScientific
{
    class getData
       
    {
        public static void getInput() {
            const bool IsAcity = true;





            Console.WriteLine("Welcome...........");

            Console.Write("input Minimum Temperature: ");

            string Mintemp = Console.ReadLine();

            double MinTemp = Convert.ToDouble(Mintemp);



            Console.Write("input Maxmum Temperature: ");

            string Maxtemp = Console.ReadLine();

            double MaxTemp = Convert.ToDouble(Maxtemp);



            Console.Write("input Average Temperature: ");

            string Averagetemp = Console.ReadLine();

            double AverageTemp = Convert.ToDouble(Averagetemp);



            Console.Write("input Population of the Town: ");

            string Populationtown = Console.ReadLine();

            int PopulationTown = Convert.ToInt32(Populationtown);





            Console.Write("input Population: ");

            string Populationstate = Console.ReadLine();

            int PopulationState = Convert.ToInt32(Populationstate);




            Console.Write("input Average Literacy Percentage: ");

            string AverageLitpercent = Console.ReadLine();

            double AverageLitPercent = Convert.ToDouble(AverageLitpercent);




            Console.Write("input Average Qaulification: ");

            string AverageQaulification = Console.ReadLine();


            Console.WriteLine("Weldone");

            Console.WriteLine("Data Inputed are As follows");


            Console.Write("Minimum Temp: ");
            Console.WriteLine(MinTemp);


            Console.Write("Maximum Temp: ");
            Console.WriteLine(MaxTemp);

            Console.Write("Average Temp: ");
            Console.WriteLine(AverageTemp);

            Console.Write("Population of the town: ");
            Console.WriteLine(PopulationTown);

            Console.Write("Population of the State: ");
            Console.WriteLine(PopulationState);

            Console.Write("is the town a city: ");
            Console.WriteLine(IsAcity);


            Console.Write("the Percentage literacy of the population: ");
            Console.WriteLine(AverageLitPercent);


            Console.Write("Population average qaulification: ");
            Console.WriteLine(AverageQaulification);


            Console.WriteLine("Done");






        }

    }
}



namespace GarciaInfoSystem
{
    class getData
    {
        public static void studData () { 
        string StudentName = "Martins";
        int Age = 50;
        string DOB = "26/01/1845";
        string Address = "22 osu ob lane";
        string FatherName = "Victor";
        string MotherName = "Nkeiru";
        string FatherOcupation = "Doctor";
        bool IsSpanishCit = true;
        char ClassDivision = 'A';
        string MajorSubjects = "Mathematics";

        DateTime DoI = DateTime.Now;

    }

         

    }
}
