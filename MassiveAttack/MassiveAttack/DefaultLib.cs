﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MassiveAttack
{
    public class DefaultLib
    {
        public ButtonEntity Default1 = new ButtonEntity("Standard");
        public ButtonEntity Default2 = new ButtonEntity("Standard");
        public ButtonEntity Default3 = new ButtonEntity("Standard");
        public ButtonEntity Default4 = new ButtonEntity("Standard");


        public DefaultLib()
        {
            this.initDefault1();
            this.initDefault2();
            this.initDefault3();
            this.initDefault4();
        }

        private void initDefault1()
        {
            Default1.isDefault = true;
            Default1.buttonAudioUri = "easy.wav";
            Default1.colorString = Default1.buttonColor.Color.ToString();
        }

        private void initDefault2()
        {
            Default2.isDefault = true;
            Default2.buttonText = "fart";
            Default2.buttonAudioUri = "fart.wav";
            Default2.buttonColor.Color = Colors.Blue;
            Default2.colorString = Default2.buttonColor.Color.ToString();
        }

        private void initDefault3()
        {
            Default3.isDefault = true;
            Default3.buttonText = "brilliant!";
            Default3.buttonAudioUri = "guiness.wav";
            Default3.buttonColor.Color = Colors.Brown;
            Default3.colorString = Default3.buttonColor.Color.ToString();
        }

        private void initDefault4()
        {
            Default4.isDefault = true;
            Default4.buttonText = "Aflac";
            Default4.buttonAudioUri = "aflac.wav";
            Default4.buttonColor.Color = Colors.Orange;
            Default4.colorString = Default4.buttonColor.Color.ToString();
        }


    }
}
