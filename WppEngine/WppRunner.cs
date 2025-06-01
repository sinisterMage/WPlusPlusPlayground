using System;
using System.Threading.Tasks;
using WPlusPlus; // Your copied AST and interpreter logic

namespace WppEngine
{
    public static class WppRunner
    {
        public static async Task<string> RunWpp(string code)
        {
            try
            {
                // Tokenize
                var tokens = Lexer.Tokenize(code);



                // Parse
                var parser = new Parser(tokens);
                var ast = parser.Parse();

                // Interpret
                var interpreter = new Interpreter();
                
                // Capture output
                var outputWriter = new StringWriter();
                Console.SetOut(outputWriter);

                 await interpreter.Evaluate(ast);
 // You may need interpreter.Interpret(ast) depending on your implementation

                return outputWriter.ToString();
            }
            catch (Exception ex)
            {
                return $"[W++ Runtime Error] {ex.Message}";
            }
        }
    }
}
