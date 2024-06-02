namespace HelloWorld;

public class SampleClass
{
    public string SayHello() => SayHello(null);

    public string SayHello(string? name) {
        string useName = "World";

        if (name != null && name.Length > 0) {
            useName = name;
        }

        return $"Hello, {useName}!";
    }
}
