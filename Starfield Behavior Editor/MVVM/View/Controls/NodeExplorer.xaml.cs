﻿using BehaviorEditor.MVVM.ViewModel;
using System;
using System.Collections;
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

namespace BehaviorEditor.MVVM.View.Controls
{
	/// <summary>
	/// Interaction logic for NodeExplorer.xaml
	/// </summary>
	public partial class NodeExplorer : UserControl
	{
		public NodeViewModel NodeSource
		{
			get => (NodeViewModel)GetValue(NodeSourceProperty);
			set => SetValue(NodeSourceProperty, value);
		}

		public static readonly DependencyProperty NodeSourceProperty =
			DependencyProperty.Register(
				nameof(NodeSource), typeof(NodeViewModel), typeof(NodeExplorer));

		public NodeExplorer()
		{
			InitializeComponent();
		}
	}
}
