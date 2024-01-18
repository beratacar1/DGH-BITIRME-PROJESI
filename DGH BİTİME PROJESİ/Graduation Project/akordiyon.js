// AKORDİYON MENÜ

var buton = document.getElementsByClassName("akordiyon")
console.log(buton)

for (var i = 0; i < buton.length; i++) {
      buton[i].onclick = function() {
        var konsol  = this.nextElementSibling;
        console.log(konsol)
        if (konsol.style.maxHeight) {
            konsol.style.maxHeight = null;
        }
        else {
            konsol.style.maxHeight = konsol.scrollHeight + "px"
        }
      }
}
