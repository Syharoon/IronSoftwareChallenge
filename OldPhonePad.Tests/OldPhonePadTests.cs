namespace OldPhonePad.Tests;

public class OldPhonePadTests
{   
    // Test cases to validate the OldPhonePad.PressedKeys method
    // Each test case includes an input string and the expected output string
    [Fact]
    public void Expected_Output_CAB()
    {
        string input = "222 2 22#";
        string expectedOutput = "CAB";
        string actualOutput = OldPhonePad.Core.OldPhonePad.PressedKeys(input);
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Expected_Output_E()
    {
        string input = "33#";
        string expectedOutput = "E";
        string actualOutput = OldPhonePad.Core.OldPhonePad.PressedKeys(input);
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Expected_Output_B()
    {
        string input = "227*#";
        string expectedOutput = "B";
        string actualOutput = OldPhonePad.Core.OldPhonePad.PressedKeys(input);
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Expected_Output_HELLO()
    {
        string input = "4433555 555666#";
        string expectedOutput = "HELLO";
        string actualOutput = OldPhonePad.Core.OldPhonePad.PressedKeys(input);
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Expected_Output_TURING()
    {
        string input = "8 88777444666*664#";
        string expectedOutput = "TURING";
        string actualOutput = OldPhonePad.Core.OldPhonePad.PressedKeys(input);
        Assert.Equal(expectedOutput, actualOutput);
    }
    
    // Test case to validate handling of invalid characters in input
    [Fact]
    public void Input_Contains_Invalid_Characters_on_beginning()
    {
        string input = "A11133#";
        Assert.Throws<ArgumentException>(() => OldPhonePad.Core.OldPhonePad.PressedKeys(input));
    }

    [Fact]
    public void Input_Contains_Invalid_Characters_on_middle()
    {
        string input = "22B33#";
        Assert.Throws<ArgumentException>(() => OldPhonePad.Core.OldPhonePad.PressedKeys(input));
    }

    [Fact]
    public void Input_Contains_Invalid_Characters_on_end()
    {
        string input = "444 667G#";
        Assert.Throws<ArgumentException>(() => OldPhonePad.Core.OldPhonePad.PressedKeys(input));
    }

}