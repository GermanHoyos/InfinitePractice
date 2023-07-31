// See https://aka.ms/new-console-template for more information
//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
 using infinitePractice;
//for non static methods inside of a accessable class *******************
	//create a referanceobject of the variable and use "new"
	//to instantiate
	//MyNonStaticClass myNonStaticClass = new MyNonStaticClass();
	//string nonStatReturned = myNonStaticClass.notStatic();
	//Console.WriteLine(nonStatReturned);
//for static methods inside of a accessable class *******************
	//simply call the static method like so
	//string statReturned = MyStaticClass.isStatic();
	//Console.WriteLine(statReturned);

//program start:
int usrInp;


string trainingChoices()
{
	Console.Clear();
	Console.WriteLine("-- The Basic Tool Set Required For Pre-Algreba: --\n" +
	" 1) Subtraction YFC:(Yoink 10's, flip/carry)\n" +
	" 2) Make 100 (9/10 rule)\n" +
	" 3) Devision (2 Decimals out)\n" +
	" 4) Adding Fractions (LCM, then add)\n" +
	" 5) Square Roots\n" +
	" *** Key Laws ***\n" +
	" 6) Alebriac Axoims, Exponent Rules\n" +
	" 7) Trig Identities\n" +
	" 8) Imaginary Numbers\n" +
	" *** Notes ***\n" +
	" It is unreasonable to ask anyone to preform\n" +
	" long devision unless they have a mastery of:\n" +
	" 9) Multiplication\n" +
	" 1) Subtraction YFC:(Yoink 10's, flip/carry)\n" +
	" 10) Prime Numbers"
	); 
	
	usrInp = Convert.ToInt32(Console.ReadLine());

	switch(usrInp)
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


	}	
	trainingChoices();
	return "";
}


trainingChoices();

//end of program
Console.ReadLine();
