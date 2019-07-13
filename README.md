# LibraryCalc09
Biblioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/7jd7x25y3o71n95l/branch/master?svg=true)](https://ci.appveyor.com/project/RafaCarva/librarycalc09/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc19.svg)

## How to install
Install-Package LibraryCalc09 -Version 1.0.3

## How to use

```cs
using LibraryCalc09;
using System;

namespace Financeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var x = calculator.OperationAdd(2, 30);
            Console.WriteLine("Value: " + x);
        }
    }
}
```
