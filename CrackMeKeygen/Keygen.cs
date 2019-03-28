using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CrackMeKeygen
{
    public partial class Keygen : MetroFramework.Forms.MetroForm
    {
        public Keygen()
        {
            InitializeComponent();
        }

        private void Keygen_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.STOPCHEATING);
            //player.PlayLooping();
        }

        //public string CreateSLicense(string Input)
        //{
        //    checked
        //    {
        //        string result;
        //        if (Input.Length < 5)
        //        {
        //            result = "Error Creating License: Length < 5.";
        //        }
        //        else
        //        {
        //            Input = Input.Replace(" ", "");
        //            char[] array = Input.ToCharArray();
        //            int[] array2 = new int[array.Length + 1];
        //            array2[array2.Length - 1] = Strings.Asc(array[0]) + Strings.Asc(array[array.Length - 1]);
        //            string text = "";
        //            int num = array.Length - 1;
        //            for (int i = 0; i <= num; i++)
        //            {
        //                array2[i] = Strings.Asc(array[i]);
        //                if (array2[i] % 2 == 0)
        //                {
        //                    array2[i] = (int)Math.Round((double)array2[i] / 2.0);
        //                }
        //                else
        //                {
        //                    array2[i] = array2[i] * 2 + 1;
        //                }
        //                text = text + Conversion.Str(array2[i]) + "-";
        //            }
        //            text += Conversion.Str(array2[array2.Length - 1]);
        //            text = text.Replace(" ", "");
        //            result = text;
        //        }
        //        return result;
        //    }
        //}

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string key = Shit();
            metroTextBoxKey.Text = key;
            Clipboard.SetText(key);
        }

        private string Shit()
        {
            Random r = new Random();
            double Gegenkathete = 1;
            double Ankathete = 1;
            double Hypotenuse = 1;

            double Sin = (int)Math.Round((Gegenkathete / Hypotenuse), 2);
            double Cos = (int)Math.Round((Ankathete / Hypotenuse), 2);
            double Tan = (int)Math.Round((Gegenkathete / Ankathete), 2);

            string Checksum = string.Format("{0}{1}{2}{3}{4}{5}",
            Gegenkathete * 3 + 1,
            Ankathete * 3 + 1,
            Sin * 3 + 1,
            Tan * 3 + 1,
            Cos * 3 + 1,
            Hypotenuse * 3 + 1);

            string key = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", Ankathete, Gegenkathete, Hypotenuse, Sin, Cos, Tan, Checksum);
            return key;
        }
    }
}
