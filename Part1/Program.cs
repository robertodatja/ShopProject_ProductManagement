/*Deri tani jemi ne gjendje te:
I.insertojme commandat ne Console
II.interpretojme ato. (insertojme/validojme cdo parameter sipas nje patterni/rregulli te caktuar)
III. konvertojme ne objekte / instanca te klases Command
Pra,
pame si te insertojme commanda dhe si t'i kthejme atone nje forme qe C# ta kuptoje me vone ose te operoje mbi ato te dhena
//Rradhes tjeter do te shohim si t'i perdorim keto komanda per qellime te ndryshme
*/

using System.Numerics;

namespace Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while (string.Compare(command, "exit", StringComparison.OrdinalIgnoreCase) != 0)
            {
                Console.Write("-> "); command = Console.ReadLine();
                try
                {
                    var lcommands = CommandInterpreter.InterpretCommandTest(command);
                    foreach (var commandTemp in lcommands) { Console.WriteLine(commandTemp.Name); }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }
        }
    }
}
//allCommmands eshte stringu  komanda1 & komanda2 & komanda3 ...
//ku cdo komande/parts ka trajten:
//parts(0) parts(1) parts(2) parts(3) parts(4) ...
//ose EmriKomandes EmriParam1 VleraParam1 EmriParam2 VleraParam2 ...

//variabli.Trim() //heq hapesirat para dhe mbrapa variablit
//variabli.Split(' ') //do t'i ndaje sipas ' '
//variabli.Substring(2) //heq dy karakteret e pare te variablit


/*Shembuj Ekzekutimi
-> Shtypim Enter
Please add at least one command to execute.

-> asdfj
asdfj

-> Add --product Mish amount 3
Bad command format.

-> Add --product Mish amount 3
Bad parameter format for: amount 

-> Add --product Mish --amount 10 --parametritjeter 23 & Remove --product veze
Add
Remove
*/

/*Procesi i ekzekutimit psh
Add --product Mish --amount 10 --parametritjeter 23 & Remove --product veze
//Hapi1
Add --product Mish --amount 10 --parametritjeter 23
Remove --product veze
//Hapi2.1
Add
--product
Mish
--amount
10
--parametritjeter
23
//Hapi2.2
Remove 
--product 
veze
*/
