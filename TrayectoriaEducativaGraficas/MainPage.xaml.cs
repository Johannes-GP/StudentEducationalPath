﻿using TrayectoriaEducativaGraficas.ViewModels;

namespace TrayectoriaEducativaGraficas
{
	public partial class MainPage : ContentPage
	{
		public MainPage(MainViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}
	}

}
