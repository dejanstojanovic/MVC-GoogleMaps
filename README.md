MVC-GoogleMaps
==============

HtmlHelper for using JQuery.GoogleMaps plugin on ASP.NET MVC pages

###What can I do with it
This is HtmlHelper for rendering out GoogleMaps either for editiong or viewing using [JQuery.GoogleMaps plugin](https://github.com/dejanstojanovic/JQuery-GoogleMaps).

The library provides:
* HtmlHelper for rendering out GoogleMap editor of viewer
* Model POCO classes
* Extension methods for serializing and deserializing map model
 
###How to add to a page
HtmlHelper for GoogleMap can be easily added as any other HtmlHelper in ASP.NET MVC. 
```razor
@Html.GoogleMap
```
However, you will have to add reference to a javascript, jquery and css files manualy in your page. You can referenci them from CDN or from local file system.
```html
<link rel="stylesheet" type="text/css" href="../src/css/mapstyle.css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
<script type="text/javascript" src="../src/jquery.googlemaps.js"></script>
```
This library is available as a NuGet package as well, so you van add it to your project through NuGet package manager or console.

[![ScreenShot](http://dejanstojanovic.net/media/23565/nuget-small.png)](https://www.nuget.org/packages/JQuery.GoogleMaps/)
