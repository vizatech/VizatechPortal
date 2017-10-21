// Write your Javascript code.
var myOptions = {
    "nativeControlsForTouch": false,
    controls: true,
    autoplay: true,
    width: "640",
    height: "400",
}
myPlayer = amp("azuremediaplayer", myOptions);
myPlayer.src([
    {
        "src": "//amssamples.streaming.mediaservices.windows.net/69fbaeba-8e92-4740-aedc-ce09ae945073/AzurePromo.ism/manifest"
        "type": "application/vnd.ms-sstr+xml"
    }
]);