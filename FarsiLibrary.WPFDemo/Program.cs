﻿using System;
using System.Windows;

namespace FarsiLibrary.WPFDemo
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                new App().Run(new Language());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}