# Cyotek ImageBox Control

## About

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

## Example Screenshots

![ImageBox control demonstration][demo1]

![Virtual mode demonstration, where the ImageBox can be used
without a backing image][demo2]

![The ImageBox can display a pixel grid when zooming in][demo3]

## License

The `ImageBox` control is licensed under the MIT License. See
`LICENSE.txt` for the full text.

## Further Reading

For more information on this control, see the [articles tagged
with **imagebox**][blog] at cyotek.com.

[demo1]:
    https://static.cyotek.com/files/articleimages/imgbox-5a.png
[demo2]:
    https://static.cyotek.com/files/articleimages/imgbox-6a.png
[demo3]:
    https://static.cyotek.com/files/articleimages/imgbox-6b.png
[blog]:https://devblog.cyotek.com/tag/imagebox
