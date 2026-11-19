namespace Lab2.Task1;

public class AccessBase
{
    public string PublicField = "public";
    private string PrivateField = "private";
    protected string ProtectedField = "protected";
    internal string InternalField = "internal";
    protected internal string ProtectedInternalField = "protected internal";
    private protected string PrivateProtectedField = "private protected";

    // Усередині базового класу доступні ВСІ шість членів
    public string ReadAllFromBase() =>
        $"{PublicField}, {PrivateField}, {ProtectedField}, " +
        $"{InternalField}, {ProtectedInternalField}, {PrivateProtectedField}";
}
