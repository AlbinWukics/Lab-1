//Skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller
//uppmanar användaren mata in en sträng i konsollen.
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.


class Lab1Class
{
    static void Main(string[] args)
    {
        Lab1Metod();
    }
    static void Lab1Metod()
    {
        long sum = 0;

        string input = "29535123p48723487597645723645";
        Console.WriteLine(input);

        //loopa för att ha ena delen för jämförelsen
        for (int i = 0; i < input.Length; i++)
        {
            //loopa igen för att ha andra delen för jämförelsen
            for (int j = i+1; j < input.Length; j++)
            {
                //i denna loopen vill vi bara hitta siffror som matchar. Använder Substring för att lösa resterande. 
                //om det är bokstav behöver du inte jämföra, hoppa till nästa input[i]
                if (char.IsLetter(input[i]) || char.IsLetter(input[j]))
                {
                    break;
                }
                //Om det är siffra, leta efter matchande siffra
                else if (input[i] == input[j])
                {

                    string middle = input.Substring(i, j+1-i);
                    // KAN OCKSÅ SKRIVAS SOM
                    // string temp2 = input[i..(j + 1)];

                    string start = input.Substring(0, i);
                    string end = input.Substring(start.Length + middle.Length);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(start);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(middle);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(end);

                    sum += long.Parse(middle);
                    break;
                }
            }           
        }
        Console.WriteLine("\n" + sum);
    }
}