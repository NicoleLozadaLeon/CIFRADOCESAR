namespace TestDemo.Tests;

public class UnitTest1
{
    [Fact]
    public void cifrado ()
    {
        string word = "HOLA";
        int k = 5;

        string ExpectedResult = "MTPF";

        string result = Algorithm.cifrado (word, k);

        Assert.Equal(ExpectedResult, result);
    }
    [Fact]
    public void cifrado2 ()
    {
        string word = "HOLA2";
        int k = 5;

        string ExpectedResult = "MTPF7";

        string result = Algorithm.cifrado (word, k);

        Assert.Equal(ExpectedResult, result);
    }
    

    
    
    [Fact]
    
    public void descifrado()
    {
        string word = "MTPF7";
        int k = 5;

        string expectedResult = "HOLA2";

        string result2 = Algorithm.descifrado (word, k);

        Assert.Equal (expectedResult, result2); 

    }
    [Fact]
    
    public void descifrado2()
    {
        string word = "MTPF";
        int k = 5;

        string expectedResult = "HOLA";

        string result2 = Algorithm.descifrado (word, k);

        Assert.Equal (expectedResult, result2); 

    }

}
