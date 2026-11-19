namespace Lab2.Task1;

public class AccessDerived : AccessBase
{
    public string ReadFromDerived()
    {
        // Для скріну 3 розкоментуйте наступний рядок (CS0122):
        // string x = PrivateField;
        return $"{PublicField}, {ProtectedField}, {InternalField}, " +
               $"{ProtectedInternalField}, {PrivateProtectedField}";
    }

    public string ReadViaBaseReference(AccessBase other)
    {
        // Для скріну 3 розкоментуйте наступний рядок (CS1540):
        // string y = other.ProtectedField;
        return other.InternalField; // internal — OK
    }
}
