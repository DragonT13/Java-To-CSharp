﻿using System;

namespace Ex07
{
	class MainApp
	{
		static void Main(string[] args)
		{
			//ArrayLength arrayLength = new ArrayLength();
			//arrayLength.PrintArrayLength();
			//Console.WriteLine();

			//Foreach @foreach = new Foreach();
			//@foreach.PrintForeach();
			//Console.WriteLine();

			//ScoreAverage scoreAverage = new ScoreAverage();
			//scoreAverage.PrintScoreAverage();
			//Console.WriteLine();

			//IrregularArray irregularArray = new IrregularArray();
			//irregularArray.PrintIrregularArray();
			//Console.WriteLine();

			//ReturnArray returnArray = new ReturnArray();
			//returnArray.PrintReturnArray();
			//Console.WriteLine();

			Calc calc = new Calc();
			calc.PrintCalc(args);
			Console.WriteLine();
		}
	}
}
