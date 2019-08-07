using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;


namespace App1_Mimica.View.Util
{
    public class LabelPontuacaoConverter : IValueConverter
    {

        //Usado quando a View Chama uma ViewModel (Converter = Concactena os Binds cm alícotas.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           if(((short)value) == 0)
            {
                
                return "Pontuacao: ";
            }
            else
            {
                return "Pontuacao: " + value;
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
