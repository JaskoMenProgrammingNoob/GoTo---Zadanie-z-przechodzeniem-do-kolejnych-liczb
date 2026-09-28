using System.ComponentModel.Design;

class Program
{

    static void Main(string[] args)
    {
        int poziom = 5;
        int podejscie = 1;
    start:
        Console.WriteLine("Podaj liczbę: ");
        int liczba = Convert.ToInt32(Console.ReadLine());
        
        switch (liczba)
        {
            case 0:
                Console.WriteLine($"Podałeś liczbę {liczba}, kończę działanie programu.");
                break;
            default:
                        Console.WriteLine($"Podałeś: {liczba}");
                        Console.WriteLine();
                        
                podejscie++;
                if(podejscie <= poziom)
                {
                    goto start;
                }
                Console.WriteLine("Koniec programu.");
                break;
        }
    }
}
                       
                    
                
                    
            
                
            
