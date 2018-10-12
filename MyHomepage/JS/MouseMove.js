function MouseMove()
{
	var $html = document.getElementsByTagName("html")[0];
    var $body = document.getElementsByTagName("body")[0];
    $html.onmousemove = function(e) {
        var  $elem= document.createElement("b");
        $elem.style.color = "#3EEDE7";
        $elem.style.zIndex = 9999;
        $elem.style.position = "absolute";
        $elem.style.select = "none";
        var x = e.pageX;
        var y = e.pageY;
        $elem.style.left = (x - 10) + "px";
        $elem.style.top = (y - 20) + "px";
        clearInterval(anim);
        $elem.innerText = "o";
        $elem.style.fontSize = Math.random() * 20 + 16 + "px";
        var increase = 0;
        var anim;
        setTimeout(function() {
            anim = setInterval(function() {
                if (++increase == 100) {
                    clearInterval(anim);
                    $body.removeChild($elem);
                }
                $elem.style.top = y - 20 - increase + "px";
                $elem.style.opacity = (150 - increase) / 120;
            }, 8);
        }, 50);
        $body.appendChild($elem);
    };
	
}
