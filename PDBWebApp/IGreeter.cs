using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PDBWebApp
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Hola";
        }
    }
} 