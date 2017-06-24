﻿using System;
using HesaEngine.SDK;
using SharpDX;
using static Simple.MenuManager;
using static Simple.SpellManager;
namespace Simple
{
    public static class DrawingManager
    {
        public static void LoadDrawings()
        {
            Drawing.OnDraw += Drawing_OnDraw;
        }
        
        private static void Drawing_OnDraw(EventArgs args)
        {
            if (!DrawingMenu.GetCheckbox("enable")) return;
            
            if (DrawingMenu.GetCheckbox("drawEmin"))
            {
                Drawing.DrawCircle(ObjectManager.Me.Position, HarassMenu.Get<MenuSlider>("rangeE").CurrentValue, Color.Green);
            }
            if (DrawingMenu.GetCheckbox("drawE"))
            {
                Drawing.DrawCircle(ObjectManager.Me.Position, E.Range, Color.Red);
            }
			if (DrawingMenu.GetCheckbox("drawR"))
			{
				Drawing.DrawCircle(ObjectManager.Me.Position, R.Range, Color.Black);
			}
		}
    }
}
