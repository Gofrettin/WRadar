﻿using System.Drawing;
using System.Drawing.Drawing2D;
using BlackRain.WowObjects;

namespace Radar.Blips
{
    internal class WowGOBlip : WowBlip
    {
        #region Properties

        protected override Color BlipColor
        {
            get { return Settings.Colors.GameObject; }
        }

        public new WowGameObject BlipObject { get; set; }

        #endregion

        #region Constructor

        public WowGOBlip(WowGameObject wowGameObject) : base(wowGameObject)
        {
            BlipObject = wowGameObject;
        }

        #endregion

        #region Methods

        #region Implimented

        /// <summary>
        /// Draws the shape for the GameObject.  Rectangle.
        /// </summary>
        /// <param name="g"><see cref="Graphics"/> object drawing the blip.</param>
        protected override void DrawShape(GraphicsPath g)
        {
            g.AddPath(Settings.Screen.ShapeGO, true);
        }

        #endregion

        #endregion
    }
}