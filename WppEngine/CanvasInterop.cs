using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace WppEngine
{
    public class CanvasInterop
    {
        private readonly IJSRuntime _js;

        public CanvasInterop(IJSRuntime js)
        {
            _js = js;
        }

        // Draws text on the canvas via JS
        public async Task DrawText(string text, int x, int y)
        {
            await _js.InvokeVoidAsync("oopsie.drawText", text, x, y);
        }

        // Draws a rectangle with color
        public async Task DrawRect(int x, int y, int width, int height, string color)
        {
            await _js.InvokeVoidAsync("oopsie.drawRect", x, y, width, height, color);
        }
    }
}
