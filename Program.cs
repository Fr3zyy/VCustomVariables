﻿using VCustomVariables.Variables;

// VInt intTest = 123;


// intTest.OnValueChanged += (oldValue, newValue) =>
// {
//     Console.WriteLine($"{oldValue} -> {newValue}");
// };

// intTest.Value = 500;

// if (intTest == 500)
// {
//     Console.WriteLine("wqdqwd");
// }

// Console.WriteLine(intTest);

// VString stringTest = "Hello world!";
// stringTest.OnValueChanged += (oldValue, newValue) =>
// {
//     Console.WriteLine($"{oldValue} -> {newValue}");
// };

// stringTest.Value = "Goodbye world!";
// Console.WriteLine(stringTest);

VBool boolTest = true;
boolTest.OnValueChanged += (oldValue, newValue) =>
{
    Console.WriteLine($"{oldValue} -> {newValue}");
};

boolTest.Value = true;

if (boolTest)
{
    Console.WriteLine("qwadqwd");
}

Console.WriteLine(boolTest);