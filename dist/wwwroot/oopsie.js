window.oopsie = {
    drawText: function (text, x, y) {
        const ctx = document.getElementById('oopsieCanvas').getContext('2d');
        ctx.font = '20px Consolas';
        ctx.fillStyle = '#000';
        ctx.fillText(text, x, y);
    },
    drawRect: function (x, y, w, h, color) {
        const ctx = document.getElementById('oopsieCanvas').getContext('2d');
        ctx.fillStyle = color;
        ctx.fillRect(x, y, w, h);
    }
};
