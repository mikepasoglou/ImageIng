using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageIng.Shared
{
    public class FilterType
    {

        public enum Filtertypes
        {
            none,
            grayscale,  //OK 
            blur,   // ok
            shepia, // ok
            postarize, // ok
            postarizestyles,
            highcontrast, //ok
            skrew3d,  //ok
            dublicate, //
            dublicatewithEffrecs,
            brightness, //OK
            contrast,
            embossed,  // OK
            sketch1, //  ligo asximo   gia prosopa  
            sketch2, //  3 x slider 
            sketch3,  // na balo X-Ray style
            edge,
            colortransformation, //ok work ok    SKCanvasView
            pastel, //ok
            bright,
            coloradjustmnet, //  very very slow  dont used 
            coloradjustmnet1,
            coloradjustmnet2,
            dilate,  //Ok
            lowlevel,
            oilpaint, 
            other,
            noimplement1,
            noimplement2,
            noimplement3,
            randommatrix,
            other1

        }
    }

    /* color picker
    // https://github.com/UdaraAlwis/Xamarin-Playground/blob/master/XFColorPickerControl/XFColorPickerControl/Controls/ColorPickerControl.xaml.cs
    public partial class ColorPickerControl : ContentView
    {

    }
    */


    }
