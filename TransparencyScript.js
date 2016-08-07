var alphaStart : float = 0.0;
var alphaEnd : float = 1.0;
var duration : float = 1.0;

function Update() {

    var lerp : float = Mathf.PingPong(Time.time,duration)/duration;
    GetComponent.<Renderer>().material.color.a = Mathf.Lerp(alphaStart,alphaEnd,lerp);

} 