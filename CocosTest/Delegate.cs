using CocosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocosTest
{
    public class Delegate:CCApplicationDelegate
    {
        public override void ApplicationDidFinishLaunching(CCApplication app, CCWindow window)
        {
            app.PreferMultiSampling = false;
            app.ContentRootDirectory = "Content";
            app.ContentSearchPaths.Add("hd");

            CCScene scene = new CCScene(window);
            CCLayerColor layer = new CCLayerColor();
            var label = new CCLabel("Tap Screen To Play!","MarkerFelt-22" , 22)
            {
                Position = layer.VisibleBoundsWorldspace.Center,
                Color = CCColor3B.Black,
                HorizontalAlignment = CCTextAlignment.Center,
                VerticalAlignment = CCVerticalTextAlignment.Center,
                AnchorPoint = CCPoint.AnchorLowerLeft,
                Dimensions = layer.ContentSize
            };
            layer.AddChild(label);
            scene.AddChild(layer);
            window.RunWithScene(scene);
        }
    }
}
