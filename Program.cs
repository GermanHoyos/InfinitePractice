//program start:
using infinitePractice;

int usrInp;

string trainingChoices()
{
    Console.Clear();
    Console.WriteLine("-- The Basic Tool Set Required For Pre-Algebra: --\n" +
    " 1) Subtraction YFC:(Yoink 10's, flip/carry)\n" +
    " 2) Make 100 (9/10 rule)\n" +
    " 3) Division (2 Decimals out)\n" +
    " 4) Adding Fractions (LCM, then add)\n" +
    " 5) Square Roots\n" +
    " *** Key Laws ***\n" +
    " 6) Algebraic Axioms, Exponent Rules\n" +
    " 7) Trig Identities\n" +
    " 8) Imaginary Numbers\n" +
    " *** Notes ***\n" +
    " It is unreasonable to ask anyone to perform\n" +
    " long division unless they have a mastery of:\n" +
    " 9) Multiplication\n" +
    " 10) Prime Numbers\n" +
    " 11) Addition (50 questions)\n" +
    " 12) Subtraction (50 questions)\n" +
    " 13) Add Or Subtract (Single Dig X 50)\n" +
    " 14) Make 10 (complements)\n" + 
    " Various Concepts in one type of problem:\n" + 
    " 15) Division or Mulitplication of negative or positive decimal numbers\n" +
    " WIP Division or Multiplication of negative or positive fractions\n" +
    " 16) Exponents " 
    );

    string input = Console.ReadLine();

    // Try to parse the user input into an integer
    if (!int.TryParse(input, out usrInp))
    {
        // If parsing fails, exit the program
        Console.WriteLine("Invalid input, exiting program.");
        Environment.Exit(0);
    }

    switch (usrInp)
    {
        case 1:
            Subtraction.SubtractionQuestion();
            Console.WriteLine("Finished");
            Console.ReadLine();
            break;
        case 2:
            Make100.Make100Questions();
            Console.WriteLine("Finished");
            Console.ReadLine();
            break;
        case 3:
            Devision.DevisionQuestions();
            Console.WriteLine("Finished");
            Console.ReadLine();
            break;
        case 4:
            FractionCustomClass.FractionQuestions();
            Console.WriteLine("Finished");
            Console.ReadLine();
            break;
        case 5:
            SquareRoots.SquareRootQuestions();
            Console.WriteLine("Finished");
            break;
        case 6:
            AlgebriacAxioms.AlgebriacAxiomQuestions();
            Console.WriteLine("Finished");
            break;
        case 7:
            TrigIdentities.TrigIdentityQuestions();
            Console.WriteLine("Finished");
            break;
        case 8:
            ImaginaryNumbers.ImaginaryNumberQuestions();
            Console.WriteLine("Finished");
            break;
        case 9:
            Multiplication.MultiplicationQuestions();
            Console.WriteLine("Finished");
            break;
        case 10:
            PrimeNumbers.PrimeNumberQuestions();
            Console.WriteLine("Finished");
            break;
        case 11:
            Addition.AdditionQuestions();
            Console.WriteLine("Finished");
            break;
        case 12:
            Subtraction50.SubtractionQuestions();
            Console.WriteLine("Finished");
            break;
        case 13:
            AdditionSubtraction.AdditionSubtractionQuestions();
            Console.WriteLine("Finished");
            break;
        case 14:
            Make10.Make10Questions();
            Console.WriteLine("Finished");
            break;
        case 15:
            DecimalDivision.DecimalDivisionQuestions();
            Console.WriteLine("Finished");
            break;
        case 16:
            Exponents.ExponentQuestions();
            Console.WriteLine("Finished");
            break;
    }

    trainingChoices();
    return "";
}

trainingChoices();

//end of program
Console.ReadLine();
