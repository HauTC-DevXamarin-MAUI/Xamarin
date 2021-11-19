using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin.Tuan3.Effects
{
    public class MyButtonEffect : RoutingEffect
    {
        public MyButtonEffect() : base("Xamarin.MyButtonEffect")
        {

        }
        public double BorderWidth { get; set; }

        public Color ColorBgr { get; set; }
    }
}
