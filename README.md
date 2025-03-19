# VCustomVariables

VCustomVariables is a library that provides custom variable types in C#. This library offers wrapper classes that trigger events when the values of variables change, making your code reactive.


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

## Installation

Clone the project from GitHub:

```
git clone https://github.com/Fr3zyy/VCustomVariables.git
```

Or add the project directly as a reference.

## Future Features

Planned variable types:
- VString
- VBool
- VFloat
- VDouble
- VList
- VDictionary

## Contributing

We welcome contributions! You can send pull requests for new features, bug fixes, or improvements.

## License

This project is licensed under the [MIT License](LICENSE).
