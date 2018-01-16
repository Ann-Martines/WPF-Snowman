using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFSnowman
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Ellipse> lstEl = new List<Ellipse>();
		DispatcherTimer timer;
		int ind = 1;
		public MainWindow()
		{
			InitializeComponent();
			Ellipse el = new Ellipse();
			el.Width = 4;
			el.Height = 4;
			
			
			for (var i = 0; i < 9; i++)
				lstEl.Add(el);
			timer = new DispatcherTimer();
			timer.Interval = new TimeSpan(0, 0, 1);
			timer.Tick += new EventHandler(new EventHandler(timer_Tick));
			timer.Start();

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if(ind %2 != 0)
			{
				a1.Fill = Brushes.White;
				a3.Fill = Brushes.White;
				a5.Fill = Brushes.White;
				a7.Fill = Brushes.White;
				a9.Fill = Brushes.White;
				a11.Fill = Brushes.White;
				a13.Fill = Brushes.White;
				a15.Fill = Brushes.White;
				a17.Fill = Brushes.White;
				a19.Fill = Brushes.White;
				a21.Fill = Brushes.White;
				a23.Fill = Brushes.White;
				a25.Fill = Brushes.White;
				a27.Fill = Brushes.White;
				a29.Fill = Brushes.White;
				a31.Fill = Brushes.White;
				a33.Fill = Brushes.White;

				a2.Fill = Brushes.MediumSlateBlue;
				a4.Fill = Brushes.MediumSlateBlue;
				a6.Fill = Brushes.MediumSlateBlue;
				a8.Fill = Brushes.MediumSlateBlue;
				a10.Fill = Brushes.MediumSlateBlue;
				a12.Fill = Brushes.MediumSlateBlue;
				a14.Fill = Brushes.MediumSlateBlue;
				a16.Fill = Brushes.MediumSlateBlue;
				a18.Fill = Brushes.MediumSlateBlue;
				a20.Fill = Brushes.MediumSlateBlue;
				a22.Fill = Brushes.MediumSlateBlue;
				a24.Fill = Brushes.MediumSlateBlue;
				a26.Fill = Brushes.MediumSlateBlue;
				a28.Fill = Brushes.MediumSlateBlue;
				a30.Fill = Brushes.MediumSlateBlue;
				a32.Fill = Brushes.MediumSlateBlue;

				b1.Fill = Brushes.Blue;
				b2.Fill = Brushes.Red;
				b3.Fill = Brushes.Green;
				b4.Fill = Brushes.Yellow;
				b5.Fill = Brushes.Blue;
				b6.Fill = Brushes.Red;
				b7.Fill = Brushes.Green;
				b8.Fill = Brushes.Yellow;
				b9.Fill = Brushes.Blue;
				b10.Fill = Brushes.Red;
				b11.Fill = Brushes.Green;
				b12.Fill = Brushes.Yellow;
				b13.Fill = Brushes.Blue;
				b14.Fill = Brushes.Red;
				b15.Fill = Brushes.Green;
				b16.Fill = Brushes.Yellow;

			}
			else
			{
				a2.Fill = Brushes.White;
				a4.Fill = Brushes.White;
				a6.Fill = Brushes.White;
				a8.Fill = Brushes.White;
				a10.Fill = Brushes.White;
				a12.Fill = Brushes.White;
				a14.Fill = Brushes.White;
				a16.Fill = Brushes.White;
				a18.Fill = Brushes.White;
				a20.Fill = Brushes.White;
				a22.Fill = Brushes.White;
				a24.Fill = Brushes.White;
				a26.Fill = Brushes.White;
				a28.Fill = Brushes.White;
				a30.Fill = Brushes.White;
				a32.Fill = Brushes.White;

				a1.Fill = Brushes.MediumSlateBlue;
				a3.Fill = Brushes.MediumSlateBlue;
				a5.Fill = Brushes.MediumSlateBlue;
				a7.Fill = Brushes.MediumSlateBlue;
				a9.Fill = Brushes.MediumSlateBlue;
				a11.Fill = Brushes.MediumSlateBlue;
				a13.Fill = Brushes.MediumSlateBlue;
				a15.Fill = Brushes.MediumSlateBlue;
				a17.Fill = Brushes.MediumSlateBlue;
				a19.Fill = Brushes.MediumSlateBlue;
				a21.Fill = Brushes.MediumSlateBlue;
				a23.Fill = Brushes.MediumSlateBlue;
				a25.Fill = Brushes.MediumSlateBlue;
				a27.Fill = Brushes.MediumSlateBlue;
				a29.Fill = Brushes.MediumSlateBlue;
				a31.Fill = Brushes.MediumSlateBlue;
				a33.Fill = Brushes.MediumSlateBlue;

				b1.Fill = Brushes.Green;
				b2.Fill = Brushes.Yellow;
				b3.Fill = Brushes.Blue;
				b4.Fill = Brushes.Red;
				b5.Fill = Brushes.Green;
				b6.Fill = Brushes.Yellow;
				b7.Fill = Brushes.Blue;
				b8.Fill = Brushes.Red;
				b9.Fill = Brushes.Green;
				b10.Fill = Brushes.Yellow;
				b11.Fill = Brushes.Blue;
				b12.Fill = Brushes.Red;
				b13.Fill = Brushes.Green;
				b14.Fill = Brushes.Yellow;
				b15.Fill = Brushes.Blue;
				b16.Fill = Brushes.Red;
			}
			ind++;
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer.Stop();
		}
	}
}
