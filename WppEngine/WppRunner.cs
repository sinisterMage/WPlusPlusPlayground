using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using WPlusPlus;

namespace WppEngine
{
    public static class WppRunner
    {
        // Optional JS runtime for future use
        public static IJSRuntime JsRuntime { get; private set; }

        public static void InjectJsRuntime(IJSRuntime jsRuntime)
        {
            JsRuntime = jsRuntime;
        }

        public static async Task<string> RunWpp(string code, CanvasInterop canvasInterop)
        {
            try
            {
                // Tokenize
                var tokens = Lexer.Tokenize(code);

                // Parse
                var parser = new Parser(tokens);
                var ast = parser.Parse();

                // Capture console output
                var outputWriter = new StringWriter();
                Console.SetOut(outputWriter);

                var interpreter = new Interpreter();

                // Register externcall handler for 'canvas'
                interpreter.RegisterExternCall("canvas", async (method, args) =>
                {
                    switch (method)
                    {
                        case "drawText":
                            await canvasInterop.DrawText(
                                args[0]?.ToString() ?? "",
                                Convert.ToInt32(args[1]),
                                Convert.ToInt32(args[2])
                            );
                            break;

                        case "drawRect":
                            await canvasInterop.DrawRect(
                                Convert.ToInt32(args[0]),
                                Convert.ToInt32(args[1]),
                                Convert.ToInt32(args[2]),
                                Convert.ToInt32(args[3]),
                                args[4]?.ToString() ?? "black"
                            );
                            break;

                        default:
                            throw new Exception($"Unknown canvas method: {method}");
                    }

                    return null; // Extern functions must return something
                });

                // Run W++ code
                await interpreter.Evaluate(ast);

                return outputWriter.ToString();
            }
            catch (Exception ex)
            {
                return $"[W++ Runtime Error] {ex.Message}";
            }
        }
    }
}
