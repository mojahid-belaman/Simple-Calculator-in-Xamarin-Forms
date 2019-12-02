using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalculatorIphone
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			btnadd.Clicked += Btnadd_Clicked;
			btnsub.Clicked += Btnsub_Clicked;
			btnmultiple.Clicked += Btnmultiple_Clicked;
			btndiv.Clicked += Btndiv_Clicked;
			btnmod.Clicked += Btnmod_Clicked;
		}

		private void Btnmod_Clicked(object sender, EventArgs e)
		{
			double r = Module(Convert.ToDouble(nb1.Text), Convert.ToDouble(nb2.Text));
			res.Text = r.ToString();
		}

		private void Btndiv_Clicked(object sender, EventArgs e)
		{
			double r = Division(Convert.ToDouble(nb1.Text), Convert.ToDouble(nb2.Text));
			res.Text = r.ToString();
		}

		private void Btnmultiple_Clicked(object sender, EventArgs e)
		{
			double r = Multi(Convert.ToDouble(nb1.Text), Convert.ToDouble(nb2.Text));
			res.Text = r.ToString();
		}

		private void Btnsub_Clicked(object sender, EventArgs e)
		{
			double r = Soustraction(Convert.ToDouble(nb1.Text), Convert.ToDouble(nb2.Text));
			res.Text = r.ToString();

		}

		private void Btnadd_Clicked(object sender, EventArgs e)
		{
			double r = Add(Convert.ToDouble(nb1.Text), Convert.ToDouble(nb2.Text));
			res.Text = r.ToString();
		}

		double Add(double num1, double num2)
		{
			return num1 + num2;
		}

		double Soustraction(double num1, double num2)
		{
			return num1 - num2;
		}

		double Multi(double num1, double num2)
		{
			return num1 * num2;
		}

		double Division(double num1, double num2)
		{
			if (num2 == 0)
			{
				DisplayAlert("ERROR", "division at 0 is not allowed", "OK");
				return (0);
			}
			else
				return num1 / num2;
		}

		double Module(double num1, double num2)
		{
			if (num2 == 0)
			{
				DisplayAlert("ERROR", "Module at 0 is not allowed", "OK");
				return (0);
			}
			else
				return num1 % num2;

		}


	}
}
