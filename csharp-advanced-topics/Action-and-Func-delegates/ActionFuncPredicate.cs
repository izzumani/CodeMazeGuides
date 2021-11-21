﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegatesInCsharp
{
    public class ActionFuncPredicate
    {

        
            public delegate TResult Func<in T, out TResult>(T arg);
           public delegate void Action<in T>(T arg);
        //public Action Void Converter<in TFrom>(TFrom input);


        public static void AddNewLogFunc(string name, int firstNumber, int secondNumber)
        {
            Func<string> func = () => "Hello ....";
            Func<string, string> func2 = (string name) => $"Hello {name} ";
            Func<string, int,int, string> func3 = (string name, int firstNumber, int secondNumber) => $"Hello,  {name}  says {firstNumber} x {secondNumber} = {firstNumber * secondNumber}";

            Console.WriteLine(string.IsNullOrWhiteSpace(func()) ? "No Return value from Func" : func());
            Console.WriteLine(string.IsNullOrWhiteSpace(func2(name)) ? "No Return value from Func2" : func2(name));
            Console.WriteLine(string.IsNullOrWhiteSpace(func3(name, firstNumber, secondNumber)) ? "No Return value from Func" : func3(name, firstNumber, secondNumber));

            
        }

        public static void AddNewLogAction(string name, int firstNumber, int secondNumber)
        {
            Action<string> action = (string name) => Console.WriteLine($"Hello {name} ");
            Action<string, int, int> action2 = (string name, int firstNumber, int secondNumber) => Console.WriteLine ($"Hello,  {name}  says {firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
            action(name);
            action2(name, firstNumber, secondNumber);

        }






    }
}