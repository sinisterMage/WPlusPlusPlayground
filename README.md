# 🌀 OOPSIEWASM
Run W++ in the browser. No JS. No HTML. Just a scripting language, WebAssembly, and a dream.

"This is probably the weirdest thing I’ve ever built."
— Me, the person who also made Kaioken Diarrhea Aura canonical

## 🧠 What is OOPSIEWASM?
OOPSIEWASM is an experimental Blazor WebAssembly playground for W++, a Python-style scripting language written in C#. It lets you write and run W++ code in your browser, without using a single line of HTML or JavaScript in the actual scripting logic.

This isn’t just a playground — it’s a statement.
A deeply cursed, mildly glorious, entirely real statement.

🚀 What can it do?
✨ Write and run W++ scripts directly in the browser

🖌️ Call browser APIs like <canvas> from W++ code using externcall

🔁 Run on pure WebAssembly using Blazor — no server required

🎨 Draw text and shapes directly from W++ without HTML

🪄 Pretend this is the future of frontend (please don’t)

## 🧪 Example

externcall("canvas", "drawText", "Hello from W++", 10, 50);
externcall("canvas", "drawRect", 20, 80, 100, 40, "red");
It draws on the canvas. From a language that doesn’t even exist in mainstream compilers.
Yes, it's that kind of project.

## 🧩 Architecture
Blazor WebAssembly for the frontend runtime

C# Interpreter for parsing and executing W++ code

CanvasInterop.cs to let W++ talk to <canvas>

No JavaScript (except glue code you don’t write)

## 💾 Try It
Try it locally (until I host it):

git clone https://github.com/sinisterMage/WPlusPlusPlayground
cd WPlusPlusPlayground/OOPSIEWASM
dotnet run
Then open in browser — and summon the void.

## 🧙‍♂️ Roadmap

 Full DOM manipulation from W++

 Button click handlers in W++

 WebGL renderer

 Replace the entire HTML spec with W++ (this is a joke… maybe)

📺 Demo Video
https://github.com/sinisterMage/WPlusPlusPlayground/blob/main/Recording%202025-06-03%20205424.mp4
(I tried YouTube. It corrupted. Hacker News didn’t believe me. So here we are.)

📜 License
MIT. Go wild. Or gently chaotic. Your choice.

🤝 Contribute?
PRs welcome. Ideas welcome. W++ evangelists extremely welcome.
If you somehow manage to make a W++ GUI library... I will cry tears of joy.

