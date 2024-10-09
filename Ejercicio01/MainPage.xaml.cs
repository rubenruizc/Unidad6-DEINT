﻿namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        bool btonCreado = false;

        public MainPage()
        {
            InitializeComponent();
        }



        private void clickBton2(object sender, EventArgs e)
        {
            var bton3 = new Button
            {
                FontFamily = "Verdana",
                Text = "Botón 3",
                FontSize = 16,
                MaximumHeightRequest = 70,
                MaximumWidthRequest = 200,
                Margin = 5,
                BackgroundColor = Colors.Blue,
                FontAttributes = FontAttributes.Bold
            };

            if (!btonCreado)
            {
                btonCreado = true;
                VSLButtom.Add(bton3);

            }


        }

    }

}