# VCustomVariables

This project is a work I created to improve my C# skills. In the project, I developed a structure to make the variables more flexible and customisable. When the value of the variable changes, an event containing the previous (oldValue) and new (newValue) values is triggered and feedback is provided. Of course, I will add more features in the future.


## Usage

### VInt Example

```csharp
// Create a VInt variable
VInt number = 123;

// Listen for value changes
number.OnValueChanged += (oldValue, newValue) =>
{
        Console.WriteLine($"Value changed: {oldValue} -> {newValue}");
};

// Change the value (triggers the event)
number.Value = 500;

// Note: Direct assignment (number = 500) does not trigger the event

// Use as an int (implicit conversion)
if (number == 500)
{
        Console.WriteLine("Value is equal to 500");
}

Console.WriteLine(number); // "500"
```

### VString Example
```csharp
// Create a VString variable
VString stringTest = "Hello world!";

// Listen for value changes
stringTest.OnValueChanged += (oldValue, newValue) =>
{
    Console.WriteLine($"{oldValue} -> {newValue}");
};

stringTest.Value = "Goodbye world!";
Console.WriteLine(stringTest); // Goodbye world!
```

### VBool Example

```csharp
// Create a VBool variable
VBool boolTest = true;

// Listen for value changes
boolTest.OnValueChanged += (oldValue, newValue) =>
{
    Console.WriteLine($"{oldValue} -> {newValue}");
};

// Change the value (triggers the event)
boolTest.Value = false;

// Use as a bool (implicit conversion)
if (boolTest)
{
    Console.WriteLine("hii");
}

Console.WriteLine(boolTest); // "False"
```


## Installation

Clone the project from GitHub:

```
git clone https://github.com/Fr3zyy/VCustomVariables.git
```

Or add the project directly as a reference.

## Future Features

Planned variable types:
- VString -> Finished
- VBool -> Finished
- VFloat
- VDouble
- VList
- VDictionary

## Contributing

We welcome contributions! You can send pull requests for new features, bug fixes, or improvements.

## License

This project is licensed under the [MIT License](LICENSE).
