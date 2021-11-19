# ![Icon][icon] Cyotek ImageBox Control

[![NuGet][nugetbadge]][nuget]

The `ImageBox` is a lightweight owner drawn control for
displaying images. It supports zooming, scrolling, panning,
region selection and much more! In addition to the traditional
mode of binding to an `Image`, you can also use a *virtual
mode*, and provide your own custom drawing whilst retaining all
the `ImageBox` functionality.

The `ImageBox` control also provides convenient helper methods
for translating points, rectangles and sizes according to the
current zoom level and scroll position of the control - this
makes it easy to scale custom drawing to fit the control.

As well as the different behaviours offered, the `ImageBox` also
supports a large number of display properties. The background of
the control can display a solid colour, or a coloured grid in
various sizes. You can also configure how the grid is to be
drawn, for example just around the image bounds, or the full
control bounds. Other options include the pixel grid, which is
displayed when zooming in on an image to highlight each pixel,
custom border styles for surrounding the image, and many other
properties. You can also display text, and specifying formatting
and alignment options.

For more information on this control, see the [articles tagged
with `imagebox`][blogtag] at cyotek.com.

## Getting the library

The easiest way of obtaining the library is via [NuGet][nuget].

> `Install-Package CyotekImageBox`

If you don't use NuGet, pre-compiled binaries can be obtained
from the [GitHub Releases page][ghrel].

Of course, you can always grab [the source][ghsrc] and build it
yourself!

## Example Screenshots

![ImageBox control demonstration][imageboxscreen]

A demonstration of the `ImageBox` control.

![Virtual mode demonstration, where the ImageBox can be used
without a backing image][virtualscreen]

Using a virtual canvas without needing a pre-rendered image

![The ImageBox can display a pixel grid when zooming
in][pixelgridscreen]

Pixel grid support when zooming into an imae

## Requirements

.NET Framework 2.0 or later.

Pre-built binaries are available via a signed [NuGet
package][nuget] containing the following targets.

* .NET 3.5
* .NET 4.0
* .NET 4.5.2
* .NET 4.6.2
* .NET 4.7.2
* .NET 4.8
* .NET 5.0
* .NET 6.0
* .NET Core App 3.1

## Contributing to this code

Contributions accepted!

* Found a problem? [Raise an issue][ghissue]
* Want to improve the code? [Make a pull request][ghpull]

Alternatively, if you make use of this software and it saves you
some time, donations are welcome.

[![PayPal Donation][paypalimg]][paypal]

[![By Me a Coffee Donation][bmacimg]][bmac]

## License

The `ImageBox` control is licensed under the MIT License. See
`license.txt` for the full text.

## Related Reading

* [Creating a scrollable and zoomable image viewer in C# Part 1][ibblog1]
* [Creating a scrollable and zoomable image viewer in C# Part 2][ibblog2]
* [Creating a scrollable and zoomable image viewer in C# Part 3][ibblog3]
* [Creating a scrollable and zoomable image viewer in C# Part 4][ibblog4]
* [Extending the ImageBox component to display the contents of a PDF file using C#][ibblog5]
* [Creating an image viewer in C# Part 5: Selecting part of an image][ibblog6]
* [Zooming into a fixed point on a ScrollableControl][ibblog7]
* [Zooming to fit a region in a ScrollableControl][ibblog8]
* [Adding drag handles to an ImageBox to allow resizing of selection regions][ibblog9]
* [Displaying multi-page tiff files using the ImageBox control and C#][ibblog10]

## Acknowledgements

### Graphics

* Toolbar icons in demonstration program from [Fugue
  Icons][fugue]
* [Treasure map][bogbrush] graphic created by
  [~Bogbrush][bogbrush]
* [Marker icon][iconlandmarker] used in Scaled Adornments
  demonstrated created by [Icons Land][iconland]
* [Large Wall Map][shadedreliefmap] image by [Tom
  Patterson][shadedrelief].
* [Newtons cradle animation book 2.gif][animation].

### Code

* Original `ScrollControl` code by [Scott Crawford][sukiware]
* Original information on pixel clipping by
  [Rotem][pixelclippingbug]
* Animated GIF support based on a contribution by [Eggy][eggy]
* Removal of .NET 3.5 requirement contributed by
  [dahmage][dagmage]
* Focusless mouse wheel scroll derived from this
  [answer][wheelscroll1] and [this answer][wheelscroll2] on
  StackOverflow as suggested by [mtagliaf][mtagliaf]

[blogtag]: https://devblog.cyotek.com/tag/imagebox

[icon]: res/icon-32.png
[imageboxscreen]: res/ib-general.png
[virtualscreen]: res/ib-virtual.png
[pixelgridscreen]: res/ib-pixelgrid.png

[nuget]: https://www.nuget.org/packages/CyotekImageBox/
[nugetbadge]: https://img.shields.io/nuget/vpre/CyotekImageBox

[ci]: https://ci.appveyor.com/project/cyotek/cyotek-windows-forms-imagebox
[cibadge]: https://img.shields.io/appveyor/build/cyotek/cyotek-windows-forms-imagebox

[ghissue]: https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox/issues
[ghpull]: https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox/pulls
[ghrel]: https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox/releases
[ghsrc]: https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox

[paypal]: https://www.paypal.me/cyotek
[paypalimg]: https://static.cyotek.com/assets/images/donate.gif
[bmac]: https://www.buymeacoffee.com/cyotek
[bmacimg]: https://static.cyotek.com/assets/images/bmac.png

[fugue]: http://p.yusukekamiyamane.com/
[bogbrush]: http://bogbrush.deviantart.com/
[bogbrushmap]: http://bogbrush.deviantart.com/art/The-Legendary-Treasure-Map-64737930
[iconland]: http://www.icons-land.com
[iconlandmarker]: https://www.iconfinder.com/icondetails/73053/128/base_map_marker_outside_pink_icon
[shadedrelief]: http://www.shadedrelief.com/
[shadedreliefmap]: http://www.shadedrelief.com/world/
[animation]: http://en.wikipedia.org/wiki/File:Newtons_cradle_animation_book_2.gif
[sukiware]: http://sukiware.com/
[pixelclippingbug]: http://stackoverflow.com/questions/14070311/why-is-graphics-drawimage-cropping-part-of-my-image/14070372#14070372
[eggy]: https://github.com/teamalpha5441
[dagmage]: https://github.com/dahmage
[wheelscroll1]: http://stackoverflow.com/a/11034674/148962
[wheelscroll2]: http://stackoverflow.com/a/13292894/148962
[mtagliaf]: http://forums.cyotek.com/imagebox/mouse-scroll-without-focusing-on-imagebox/msg194/#msg194

[ibblog1]: https://devblog.cyotek.com/post/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-1
[ibblog2]: https://devblog.cyotek.com/post/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-2
[ibblog3]: https://devblog.cyotek.com/post/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-3
[ibblog4]: https://devblog.cyotek.com/post/creating-a-scrollable-and-zoomable-image-viewer-in-csharp-part-4
[ibblog5]: https://devblog.cyotek.com/post/extending-the-imagebox-component-to-display-the-contents-of-a-pdf-file-using-csharp
[ibblog6]: https://devblog.cyotek.com/post/creating-an-image-viewer-in-csharp-part-5-selecting-part-of-an-image
[ibblog7]: https://devblog.cyotek.com/post/zooming-into-a-fixed-point-on-a-scrollablecontrol
[ibblog8]: https://devblog.cyotek.com/post/zooming-to-fit-a-region-in-a-scrollablecontrol
[ibblog9]: https://devblog.cyotek.com/post/adding-drag-handles-to-an-imagebox-to-allow-resizing-of-selection-regions
[ibblog10]: https://devblog.cyotek.com/post/displaying-multi-page-tiff-files-using-the-imagebox-control-and-csharp
