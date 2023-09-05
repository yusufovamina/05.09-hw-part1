var madrid = new Spain.Madrid();
var ottawa = new Canada.Ottawa();
var london = new UK.London();
long[] populations = new long[3] {madrid.Population,ottawa.Population,london.Population};
Console.WriteLine($"Population of {madrid.Name}, Spain: {madrid.Population} million");
Console.WriteLine($"Population of {ottawa.Name}, Canada: {ottawa.Population} million");
Console.WriteLine($"Population of {london.Name}, UK: {london.Population} million");

Console.WriteLine();
Comparison(populations);
void Comparison(params long[] populations) {
    long max = populations[0], min=populations[0];
    for (int i = 0; i < populations.Length; i++)
    {
        if (populations[i]> max)
        {
            max = populations[i];
        }
        if (populations[i]< min)
        {
            min = populations[i];
        }
    }
    Console.WriteLine($"The largest population is {max}, smallest is {min}");
}



namespace Spain
{
    public class Madrid
    {   public string Name;
        public long Population { get; set; }
        public Madrid()
        {
            Name = "Madrid";
            Population = 6751000;
        }

    }
}

namespace Canada
{
    public class Ottawa
    {
        public string Name;
        public long Population{get; set;}

        public Ottawa()
        {
            Name = "Ottawa";
            Population = 1111773;
        }
    }
}

namespace UK
{
   
    public class London
    { public string Name;
        public long Population { get; set; }

        public London()
        {
            Name = "London";
            Population = 9648000;
        }
    }
}