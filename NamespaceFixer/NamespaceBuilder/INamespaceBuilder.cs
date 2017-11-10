namespace NamespaceFixer.NamespaceBuilder
{
    internal interface INamespaceBuilder
    {
        string GetIdealNamespace(string filePath, string basePath);

        string GetIdealNamespace2(string filePath, string solutionPath);
    }
}