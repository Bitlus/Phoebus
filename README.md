# Phoebus
A simple string validation library that avoids using regex.

## Example usage
```cs
using Phoebus;
...
var testString = "test";
testString.IsAlphabetical(); // true
testString.IsAlphanumeric(); // true
testString.IsNumeric(); // false
testString.IsInCharacterSet("est"); // true
testString.IsInCharacterSet("@#$%^&*"); // false
```

