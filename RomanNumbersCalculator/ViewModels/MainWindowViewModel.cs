using ReactiveUI;
using RomanNumbersCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Security.Cryptography;
using System.Text;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string currentOperationStringRepresentation = "";
        private string currentNumberStringRepresentation = "";
        private Stack<RomanNumberExtend> StackRomanNumbers = new Stack<RomanNumberExtend>();

        public string CurrentNumberStringRepresentation
        {
            get => currentNumberStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
            }
        }
        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> PlusCommand { get; }
        public ReactiveCommand<Unit, Unit> SubCommand { get; }
        public ReactiveCommand<Unit, Unit> MulCommand { get; }
        public ReactiveCommand<Unit, Unit> DivCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }

        public MainWindowViewModel()
        {
            AddNumber = ReactiveCommand.Create<string>(str => {
                if (currentOperationStringRepresentation == "=")
                {
                    CurrentNumberStringRepresentation = str;
                    StackRomanNumbers.Clear();
                    currentOperationStringRepresentation = "";
                }
                else
                {
                    if (currentNumberStringRepresentation != "#ERROR") CurrentNumberStringRepresentation += str;
                }
            });
            PlusCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "" && currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "+";
                        return;
                    }
                    if (currentNumberStringRepresentation == "") return;
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "+";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "+";
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(Num);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + Num);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - Num);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * Num);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / Num);
                                        break;
                                }
                                currentOperationStringRepresentation = "+";
                                CurrentNumberStringRepresentation = "";

                            }
                        }
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            SubCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "" && currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "-";
                        return;
                    }
                    if (currentNumberStringRepresentation == "") return;
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "-";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "-";
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(Num);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + Num);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - Num);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * Num);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / Num);
                                        break;
                                }
                                currentOperationStringRepresentation = "-";
                                CurrentNumberStringRepresentation = "";

                            }
                        }
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            MulCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "" && currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "*";
                        return;
                    }
                    if (currentNumberStringRepresentation == "") return;
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "*";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "*";
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(Num);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + Num);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - Num);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * Num);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / Num);
                                        break;
                                }
                                currentOperationStringRepresentation = "*";
                                CurrentNumberStringRepresentation = "";

                            }
                        }
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            DivCommand = ReactiveCommand.Create(() => {
                if (currentNumberStringRepresentation != "#ERROR")
                {
                    if (currentNumberStringRepresentation == "" && currentOperationStringRepresentation != "")
                    {
                        currentOperationStringRepresentation = "/";
                        return;
                    }
                    if (currentNumberStringRepresentation == "") return;
                    try
                    {
                        if (currentOperationStringRepresentation == "=")
                        {
                            currentOperationStringRepresentation = "/";
                            CurrentNumberStringRepresentation = "";
                        }
                        else
                        {
                            if (currentOperationStringRepresentation == "")
                            {
                                currentOperationStringRepresentation = "/";
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                StackRomanNumbers.Push(Num);
                                CurrentNumberStringRepresentation = "";
                            }
                            else
                            {
                                RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                                switch (currentOperationStringRepresentation)
                                {
                                    case "+":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() + Num);
                                        break;
                                    case "-":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() - Num);
                                        break;
                                    case "*":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() * Num);
                                        break;
                                    case "/":
                                        StackRomanNumbers.Push(StackRomanNumbers.Pop() / Num);
                                        break;
                                }
                                currentOperationStringRepresentation = "/";
                                CurrentNumberStringRepresentation = "";

                            }
                        }
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            CalculateCommand = ReactiveCommand.Create(() =>
            {
                if (StackRomanNumbers.Count == 1 && currentNumberStringRepresentation != "" && currentNumberStringRepresentation != "#ERROR")
                {
                    try
                    {
                        RomanNumberExtend Num = new RomanNumberExtend(currentNumberStringRepresentation);
                        switch (currentOperationStringRepresentation)
                        {
                            case "+":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() + Num);
                                break;
                            case "-":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() - Num);
                                break;
                            case "*":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() * Num);
                                break;
                            case "/":
                                StackRomanNumbers.Push(StackRomanNumbers.Pop() / Num);
                                break;
                        }
                        currentOperationStringRepresentation = "=";
                        CurrentNumberStringRepresentation = StackRomanNumbers.Peek().ToString();
                    }
                    catch (RomanNumberException ex)
                    {
                        CurrentNumberStringRepresentation = ex.Message;
                    }
                }
            });
            ResetCommand = ReactiveCommand.Create(() => {
                CurrentNumberStringRepresentation = "";
                StackRomanNumbers.Clear();
                currentOperationStringRepresentation = "";
            });
        }
    }
}
